using System;
using System.Collections.Generic;

namespace Implementation_StackLIFO.Library{
    /// <summary>
    /// Implementación de una pila (stack)
    /// de tipo LIFO (Last In, First Out)
    /// </summary>
    /// <typeparam name="T">
    /// Tipo de elemento a insertar en la lista.
    /// </typeparam>
    public class StackLIFO<T>{
        /// <summary>
        /// Lista privada encargada de almacenar los
        /// elementos que se van almacenando.
        /// </summary>
        private List<T> stackList;

        /// <summary>
        /// Constructor de la clase,
        /// encargado de inicializar la lista.
        /// </summary>
        public StackLIFO()
        {
            stackList = new List<T>();
        }

        /// <summary>
        /// El método Push permite apilar un elemento dentro de la lista.
        /// </summary>
        /// <param name="value">Elemento a insertar del tipo definido.</param>
        public void Push(T value){
            stackList.Add(value);
        }

        /// <summary>
        /// El método Peek permite obtener el último elemento apilado en la lista.
        /// </summary>
        /// <returns>Objeto del valor definido</returns>
        public T Peek(){
            return stackList[stackList.Count - 1];
        }

        /// <summary>
        /// El método count permite obtener el número de elementos
        /// almacenado en la lista.
        /// </summary>
        /// <returns>Entero con el número de elemento.</returns>
        public int Count(){
            return stackList.Count;
        }

        /// <summary>
        /// Método para obtener el tipo de elementos que se almacenan en la lista.
        /// </summary>
        /// <returns>Type del objeto definido.</returns>
        new public Type GetType(){
            return typeof(T);
        }
    }
}