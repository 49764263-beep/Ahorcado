namespace TP03_Aguirre_Hilú.Models;
public class PalabrasAhorcado{
    private List<string> palabras;
    public PalabrasAhorcado(){
        palabras = new List<string> {"EFERVECENCIA", "ESFEROIDE", "CALEIDOSCOPIO", "TELESCOPIO", "APERCIBIMIENTO", "TRANSUSTENTACION", "ELECTROCARDIOGRAMA", "MARCHI", "ELECTROENCEFALOGO", "DESOXIRIBONUCLEICO"};
    }
    public string ObtenerPalabra(){
        Random random = new Random();
        int numeroRandom = random.Next(0, 9);
        return palabras[numeroRandom];
    }
    public string PalabraAGuion(string palabra){
        string PalabraConGuiones = "";
        for (int i = 0; i < palabra.Length; i++){
            PalabraConGuiones = PalabraConGuiones + "_";
        }
        return PalabraConGuiones;
    }
}