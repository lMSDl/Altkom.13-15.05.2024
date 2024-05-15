using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //każda klasa dziedziczy niejawnie po klasie Object
    // : - oznacza dziedziczenie po wskazanej klasie
    //klasa abstrakcyjna to klasa, której instancji nie możemy utworzyć  (mimo posiadania publicznego konstruktora)
    internal abstract class Shape /*: Object*/
    {
        //protected - modyfikator dostępu pozwalający korzystać typom pochodnym ale na zewnątrz działa jak private
        protected string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        //virtual - pozwala zmienić implementację metody w klasach pochodnych (override)
        public virtual string GetName()
        {
            return Name;
        }
    }
}
