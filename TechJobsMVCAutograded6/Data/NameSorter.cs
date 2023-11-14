using System;
using System.Diagnostics.CodeAnalysis;

namespace TechJobsMVCAutograded6.Data;

public class NameSorter : IComparer<object>
{
    public int Compare([AllowNull] object x, [AllowNull] object y)
    {
        return x.ToString().ToLower().CompareTo(y.ToString().ToLower());
    }
}


