using System.Data;
using Dapper;

namespace HamedStack.Dapper;

/// <summary>
/// Handles conversion between the <see cref="TimeOnly"/> type and the SQL database representation.
/// </summary>
public class SqlTimeOnlyTypeHandler : SqlMapper.TypeHandler<TimeOnly>
{
    /// <summary>
    /// Converts a <see cref="TimeOnly"/> instance to a format suitable for SQL database storage.
    /// </summary>
    /// <param name="parameter">The SQL parameter to which the value will be assigned.</param>
    /// <param name="time">The <see cref="TimeOnly"/> instance to convert.</param>
    public override void SetValue(IDbDataParameter parameter, TimeOnly time)
    {
        parameter.Value = time.ToString();
    }

    /// <summary>
    /// Parses a database value back to a <see cref="TimeOnly"/> instance.
    /// </summary>
    /// <param name="value">The database value to parse.</param>
    /// <returns>A <see cref="TimeOnly"/> instance corresponding to the value.</returns>
    public override TimeOnly Parse(object value) => TimeOnly.FromTimeSpan((TimeSpan)value);
}