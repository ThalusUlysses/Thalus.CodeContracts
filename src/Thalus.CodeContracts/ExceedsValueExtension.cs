using System;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public static class ExceedsValueExtension
    {
        public static void ExceedsMax(this ICodeContract c, object o, object limit, string message = null,
            Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            bool harmed = false;
            if (o is double d && limit is double dLim && d > dLim)
            {
                harmed = true;
            }
            else if (o is int i && limit is int iLim && i > iLim)
            {
                harmed = true;

            }
            else if (o is float f && limit is float fLim && f > fLim)
            {
                harmed = true;

            }
            else if (o is byte b && limit is byte bLim && b > bLim)
            {
                harmed = true;

            }
            else if (o is short s && limit is short sLim && s > sLim)
            {
                harmed = true;

            }
            else if (o is char ch && limit is char chLim && ch > chLim)
            {
                harmed = true;
            }
            else
            if (o is string st && limit is int stLim && st.Length > stLim)
            {
                harmed = true;
            }

            if (harmed)
            {
                Exception ex = new ArgumentOutOfRangeException($"Code Contract harmed, parameter is out of range {o} > {limit}, {message}");

                throw c.Encapsulate(ex, exceptionType);
            }
        }

        public static void ExceedsMin(this ICodeContract c, object o, object limit, string message = null,
            Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            bool harmed = false;
            if (o is double d && limit is double dLim && d < dLim)
            {
                harmed = true;
            }
            else if (o is int i && limit is int iLim && i < iLim)
            {
                harmed = true;

            }
            else if (o is float f && limit is float fLim && f < fLim)
            {
                harmed = true;

            }
            else if (o is byte b && limit is byte bLim && b < bLim)
            {
                harmed = true;

            }
            else if (o is short s && limit is short sLim && s < sLim)
            {
                harmed = true;

            }
            else if (o is char ch && limit is char chLim && ch < chLim)
            {
                harmed = true;
            }
            else
            if (o is string st && limit is int stLim && st.Length < stLim)
            {
                harmed = true;
            }

            if (harmed)
            {
                Exception ex = new ArgumentOutOfRangeException($"Code Contract harmed, parameter is out of range {o} > {limit}, {message}");

                throw c.Encapsulate(ex, exceptionType);
            }
        }
    }
}