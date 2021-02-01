using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HSchool.Lib.Helpers
{
    public static class StringExtensions
    {
        public static string ToTglDMY(this string stringTgl)
        {
            DateTime dummyDate;
            //  coba parsing sebagai DMY
            bool isValid = DateTime.TryParseExact(stringTgl, "dd-MM-yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dummyDate);

            //  jika tidak berhasil, parsing sebagai YMD
            if (!isValid)
            {
                isValid = DateTime.TryParseExact(stringTgl, "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out dummyDate);
            }

            if (isValid)
            {
                return dummyDate.ToString("dd-MM-yyyy");
            }
            else
            {
                throw new InvalidOperationException("Invalid string date");
            }
        }

        public static string ToTglYMD(this string stringTgl)
        {
            DateTime dummyDate;
            //  coba parsing sebagai DMY
            bool isValid = DateTime.TryParseExact(stringTgl, "dd-MM-yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dummyDate);

            //  jika tidak berhasil, parsing sebagai YMD
            if (!isValid)
            {
                isValid = DateTime.TryParseExact(stringTgl, "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out dummyDate);
            }

            if (isValid)
            {
                return dummyDate.ToString("yyyy-MM-dd");
            }
            else
            {
                throw new InvalidOperationException("Invalid string date");
            }
        }

        public static bool IsValidJam(this string jam, string format)
        {
            DateTime dummyDate;
            return DateTime.TryParseExact(jam, format,
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dummyDate);
        }

        /// <summary>
        ///     Cek validitas format JAM dalam string
        /// </summary>
        /// <param name="tgl"></param>
        /// <param name="format">dd-MM-yyyy, yyyy-MM-dd</param>
        /// <returns></returns>
        public static bool IsValidTgl(this string tgl, string format)
        {
            DateTime dummyDate;
            return DateTime.TryParseExact(tgl, format,
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dummyDate);
        }

        public static DateTime ToDate(this string stringTgl)
        {
            DateTime dummyDate;
            //  coba parsing sebagai DMY
            bool isValid = DateTime.TryParseExact(stringTgl, "dd-MM-yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dummyDate);

            //  jika tidak berhasil, parsing sebagai YMD
            if (!isValid)
            {
                isValid = DateTime.TryParseExact(stringTgl, "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out dummyDate);
            }

            if (isValid)
            {
                return dummyDate;
            }
            else
            {
                throw new InvalidOperationException("Invalid string date");
            }
        }

        public static string GetHariName(this string stringTgl)
        {
            var dtTgl = ToDate(stringTgl);
            var culture = new System.Globalization.CultureInfo("id-ID");
            var hariName = culture.DateTimeFormat.GetDayName(dtTgl.DayOfWeek);
            return hariName;
        }

        public static string GetHariName(this DayOfWeek dayOfWeek)
        {
            var culture = new System.Globalization.CultureInfo("id-ID");
            var hariName = culture.DateTimeFormat.GetDayName(dayOfWeek);
            return hariName;
        }

        public static string GetHariName(this int intDay)
        {
            var culture = new System.Globalization.CultureInfo("id-ID");
            var hariName = culture.DateTimeFormat.GetDayName((DayOfWeek)intDay);
            return hariName;
        }

        public static long Timestamp(this DateTime tgl)
        {
            var timestamp = tgl.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
            return (long)timestamp;
        }

    }
}