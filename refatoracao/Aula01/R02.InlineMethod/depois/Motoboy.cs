namespace refatoracao.R02.InlineMethod.depois
{
    class Motoboy
    {
        private int qtdeEntregasNoturnas;

        int GetAvaliacao()
        {
            return (qtdeEntregasNoturnas > 5) ? 2 : 1;
        }
    }
}
