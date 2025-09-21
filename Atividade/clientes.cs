namespace Atividade
{
    class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; set; }
        public float valor_imposto { get; set; }
        public float total { get; set; }

        public virtual void Pagar_imposto(float v)
        {
            // Este método será sobrescrito pelas classes filhas
        }
    }
}
