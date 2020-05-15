using System.Collections.Generic;

namespace WindowsFormsAppProject
{
    public class clsUtils
    {
        #region Lists
        public static List<string> listaMarche = new List<string>();
        public static List<string> listaColori = new List<string>();
        #endregion

        #region Controls
        public static void controlloColore(string color)
        {
            bool ok = false;
            for (int i = 0; i < listaColori.Count; i++)
            {
                if (listaColori[i] == color)
                {
                    ok = true;
                }
            }
            if (!ok)
            {
                listaColori.Add(color);
            }
        }

        public static void controlloMarca(string marca)
        {
            bool ok = false;
            for (int i = 0; i < listaMarche.Count; i++)
            {
                if (listaMarche[i] == marca)
                {
                    ok = true;
                }
            }
            if (!ok)
            {
                listaMarche.Add(marca);
            }
        }
        #endregion
    }
}
