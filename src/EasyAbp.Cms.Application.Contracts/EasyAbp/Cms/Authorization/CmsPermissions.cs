using Volo.Abp.Reflection;

namespace EasyAbp.Cms.Authorization
{
    public class CmsPermissions
    {
        public const string GroupName = "Cms";
        
        public class Categories
        {
            public const string Default = GroupName + ".Category";
            
            public const string Create = Default + ".Create";
            
            public const string Update = Default + ".Update";
            
            public const string Delete = Default + ".Delete";
        }
        
        public class Articles
        {
            public const string Default = GroupName + ".Article";
            
            public const string Create = Default + ".Create";
            
            public const string Update = Default + ".Update";
            
            public const string Delete = Default + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(CmsPermissions));
        }
    }
}