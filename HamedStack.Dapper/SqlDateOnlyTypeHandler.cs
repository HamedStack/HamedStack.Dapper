using System.Data;
using Dapper;

namespace HamedStack.Dapper;

/// <summary>
/// Handles conversion between the <see cref="DateOnly"/> type and the SQL database representation.
/// </summary>
public class SqlDateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    /// <summary>
    /// Converts a <see cref="DateOnly"/> instance to a format suitable for SQL database storage.
    /// </summary>
    /// <param name="parameter">The SQL parameter to which the value will be assigned.</param>
    /// <param name="date">The <see cref="DateOnly"/> instance to convert.</param>
    public override void SetValue(IDbDataParameter parameter, DateOnly date)
        => parameter.Value = date.ToDateTime(new TimeOnly(0, 0));

    /// <summary>
    /// Parses a database value back to a <see cref="DateOnly"/> instance.
    /// </summary>
    /// <param name="value">The database value to parse.</param>
    /// <returns>A <see cref="DateOnly"/> instance corresponding to the value.</returns>
    public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);
}