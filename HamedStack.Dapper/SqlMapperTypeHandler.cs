using Dapper;

namespace HamedStack.Dapper;

/// <summary>
/// Provides functionality to add type handlers for <see cref="DateOnly"/> and <see cref="TimeOnly"/> types to Dapper's <see cref="SqlMapper"/>.
/// </summary>
public static class SqlMapperTypeHandler
{
    /// <summary>
    /// Registers the <see cref="SqlDateOnlyTypeHandler"/> and <see cref="SqlTimeOnlyTypeHandler"/> with Dapper's <see cref="SqlMapper"/>.
    /// </summary>
    public static void AddDateOnlyTimeOnlyTypeHandlers()
    {
        SqlMapper.AddTypeHandler(new SqlDateOnlyTypeHandler());
        SqlMapper.AddTypeHandler(new SqlTimeOnlyTypeHandler());
    }
}