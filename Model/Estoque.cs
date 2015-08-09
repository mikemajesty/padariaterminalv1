
namespace Model
{
    public class Estoque
    {
        public int Id { get; set; }
        public  int Quantidade { get; set; }
        //---------------------------------------------Usado para Execuções mais Não faz Parte Da "Classe"
        //Usado No Form 
        public string Operacao { get; set; }
        public string Codigo { get; set; }
    }
}
