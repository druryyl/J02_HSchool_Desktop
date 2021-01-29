using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Intersolusi.Helper
{
    public interface IParamNoBL
    {
        string GenNewID(string prefix, ParamNoLengthEnum length);
    }

    public enum ParamNoLengthEnum
    {
        Code_5,
        Code_12,
        Code_14
    }


    public class ParamNoBL : IParamNoBL
    {
        private readonly IParamNoDal _paramNoDal;

        public ParamNoBL(IParamNoDal paramNoDal)
        {
            _paramNoDal = paramNoDal;
        }
        private string GenNewID(IParamNoKey key)
        {
            /*  Cek apakah paramkey sudah ada di database
             *  Jika sudah ada, ambil nilai-nya, setu retVal, 
             *  dan tambahkan satu (hexa-desimal mode)
             */
            var param = _paramNoDal.GetData(key);
            if (param == null)
                param = new ParamNoModel
                {
                    ParamID = key.ParamID,
                    ParamValue = "0"
                };
            var retVal = param.ParamValue;
            param.ParamValue = AddHexa(param.ParamValue, "1");
            _paramNoDal.Delete(key);
            _paramNoDal.Insert(param);

            return retVal;
        }

        public string GenNewID(string prefix, ParamNoLengthEnum length)
        {
            /*  BE000           = Code_5
             *  CI20A-0000-A    = Code_12
             *  US206-00-000-A  = Code_14
             */

            var periode = DateTime.Now.ToString("yy");
            switch (DateTime.Now.Month)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    periode += DateTime.Now.Month.ToString();
                    break;
                case 10:
                    periode += "A";
                    break;
                case 11:
                    periode += "B";
                    break;
                case 12:
                    periode += "C";
                    break;
            }

            var param = new ParamNoModel
            {
                ParamID = $"{prefix}-{periode}"
            };
            var noUrutHex = GenNewID(param);
            var random = new Random();
            var num = random.Next(0, 15);
            var checkDigit = num.ToString("X");
            string noUrutBlok = "";
            switch (length)
            {
                case ParamNoLengthEnum.Code_5:
                    noUrutBlok = $"-{noUrutHex.PadLeft(2, '0')}";
                    periode = "";
                    checkDigit = "";
                    break;
                case ParamNoLengthEnum.Code_12:
                    noUrutBlok = $"-{noUrutHex.PadLeft(4, '0')}";
                    periode = $"-{periode}";
                    checkDigit = $"-{checkDigit}";
                    break;
                case ParamNoLengthEnum.Code_14:
                    noUrutBlok = $"{noUrutHex.PadLeft(5, '0')}";
                    noUrutBlok = $"{noUrutBlok.Substring(0, 2)}-{noUrutBlok.Substring(2, 3)}";
                    periode = $"-{periode}";
                    checkDigit = $"-{checkDigit}";
                    break;
                default:
                    break;
            }

            var result = $"{prefix}{periode}{noUrutBlok}{checkDigit}";
            return result;
        }

        private string AddHexa(string h1, string h2)
        {
            BigInteger number1 = BigInteger.Parse(h1, NumberStyles.HexNumber);
            BigInteger number2 = BigInteger.Parse(h2, NumberStyles.HexNumber);
            BigInteger sum = BigInteger.Add(number1, number2);
            return sum.ToString("X");
        }
    }

    public interface IParamNoKey
    {
        string ParamID { get; set; }
    }

    public class ParamNoModel : IParamNoKey
    {
        public string ParamValue { get; set; }
        public string ParamID { get; set; }
    }
    public interface IParamNoDal
    {
        void Insert(ParamNoModel paramNo);
        void Update(ParamNoModel paramNo);
        void Delete(IParamNoKey key);
        ParamNoModel GetData(IParamNoKey key);
        IEnumerable<ParamNoModel> ListData();
    }
}

