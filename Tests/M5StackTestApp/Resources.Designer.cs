//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M5StackTestApp
{
    
    internal partial class Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resources.manager == null))
                {
                    Resources.manager = new System.Resources.ResourceManager("M5StackTestApp.Resources", typeof(Resources).Assembly);
                }
                return Resources.manager;
            }
        }
        internal static nanoFramework.UI.Font GetFont(Resources.FontResources id)
        {
            return ((nanoFramework.UI.Font)(nanoFramework.Runtime.Native.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            segoeuiregular12 = 21930,
        }
    }
}
