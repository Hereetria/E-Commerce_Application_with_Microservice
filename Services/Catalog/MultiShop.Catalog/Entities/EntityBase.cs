using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Reflection;

namespace MultiShop.Catalog.Entities
{
    public class EntityBase<TEntity>
    {
        public static string GetIdFieldName()
        {
            return typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(p => p.Name.EndsWith("Id", StringComparison.OrdinalIgnoreCase))?.Name;
        }

    }
}
