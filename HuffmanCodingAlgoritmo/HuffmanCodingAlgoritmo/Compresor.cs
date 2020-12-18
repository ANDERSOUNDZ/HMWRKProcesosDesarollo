using System;
using System.Collections;

namespace HuffmanCodingAlgoritmo
{
    internal class Compresor
    {
        public Compresor()
        {

        }

        internal BitArray Huffman(string cadenaSinComprimir)
        {
            var frecuencia = CalcularFrecuencia(cadenaSinComprimir);
            //ordenar ascendente necesita prueba unitaria
            //nodo necesita prueba unitaria
            //calcular freuencia prueba unitaria
            var frecuenciaOrdenada = OrdenarAscendente(frecuencia);
            var arbol = new Nodo();

            foreach(var caracter in frecuenciaOrdenada) //RemplazarForeachSentenciaTipoWhileTeniendo en cuenta que extraer meno elimina elementos de la frecuencia
            {
                var nuevoNodo = new Nodo();
                nuevoNodo.NodoIzquierdo = ExtraerMenor(frecuenciaOrdenada);
                nuevoNodo.NodoDerecho = ExtraerMenor(frecuenciaOrdenada  );

                nuevoNodo.Valor = nuevoNodo.NodoIzquierdo.Valor + nuevoNodo.NodoDerecho.Valor;
                arbol.Insertar(nuevoNodo);
            }


            BitArray Huffman (string cadenaSinComprimir)
            {
                var frecuencia = CalcularFrecuencia(cadenaSinComprimir);
                var frecuenciaOrdenada = Ordenar(frecuencia, Orden.Ascendente);

                while (frecuencia.Count > 1)
                {
                    var nuevoNodo = new Nodo();
                    {
                        HijIzquierdo = ExtraerValorMinimo(frecuencia);
                        HioDerecho = ExtraerValorMinimo(frecuencia);
                    }
                }
            }
            
        }
    }
}