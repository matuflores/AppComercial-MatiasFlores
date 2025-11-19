using AppComercial.Entidades.DTOs.Marca;

namespace AppComercial.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case MarcaListDto marca:
                    r.Cells[0].Value = marca.MarcaId;
                    r.Cells[1].Value = marca.Descripcion;
                    break;
            }
            r.Tag = obj;

        }

        public static void AgregarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Add(r);
        }

        public static void QuitarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

    }
}
