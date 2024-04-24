namespace Global.Shared.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
        public string Class { get; set; }
        public int Ordem { get; set; }
        public List<MenuDto> SubMenus { get; set; } = new();
    }

    public class BuscarMenus
    {
        public const string MENU_HOME = "HO00";
        public const string MENU_HOME_SUB1 = "HO01";

        public const string MENU_RESTAURANTE = "RE00";

        public const string MENU_ECOMMERCE = "EC00";


        public static List<MenuDto> Sidebar()
        {
            int ordemMenu = 0;
            //int ordemSubMenu = 0;

            List<MenuDto> lista = new()
                {
                    new MenuDto
                    {
                        Codigo = MENU_HOME,
                        Titulo = "Home",
                        Ordem = ordemMenu++,
                        Class ="Home",
                        Url = ""
                    },
                    new MenuDto
                    {
                        Codigo = MENU_RESTAURANTE,
                        Titulo = "Restaurante",
                        Ordem = ordemMenu++,
                        Class ="Restaurante",
                        Url = "https://localhost:44336/"
                    },
                    new MenuDto
                    {
                        Codigo = MENU_ECOMMERCE,
                        Titulo = "ECommerce",
                        Ordem = ordemMenu++,
                        Class ="Ecommerce",
                        Url = "https://localhost:44382/",
                        //SubMenus = new List<MenuDto>
                        //    {
                        //        new MenuDto
                        //        {
                        //            Codigo = MENU_HOME_SUB1,
                        //            Text = "SubMenu1",
                        //            Url = "/submenu1",
                        //            Ordem = ordemSubMenu++
                        //        },
                        //    }
                    },
            };
            return lista;
        }
    }
}
