
//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace "zaciągamy" używając "using"
namespace ConsoleApp.Models
{
    //pełna nazwa klasy to <namespace>.<nazwa>
    // <modyfikator dostępu> class <nazwaKlasy>

    //internal - modyfikator dostępu - oznacza, że z klasy można korzystać tylko w projekcie "rodzimym"
    //public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
    // brak modyfikatora dostępu = internal
    //class - szablon opisujący zachowania i cechy (stan) obiektów (instancji klas), które są wytwarzane na jej podstawie
    public class Person
    {

        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy
        //public - dostęp zewsząd
        //brak modyfikatora = private
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        //pola prywane powinny być nazywane: <nazwa> / _<nazwa> / m_<nazwa>
        private string _name;

        //getter pobiera wartość pola _name - metoda zwraca typ zgodny z typem pola
        //string - metoda zwraca string
        public string GetName()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return _name; //zwracany obiekt musi mieć typ zgodny z definicją metody.
        }

        //setter - do ustawiania wartości imienia - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        //void - metoda nic nie zwaraca
        internal void SetName(string name)
        {
            _name = name/*.ToUpper()*/;
        }

        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość zmiany modyfikatora dostępu dla getter lub setter (osobno)
        public int Age { /*internal*/ get; set; }


        //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze
        private string _lastName;
        //full-property
        public string LastName
        {
            //getter dla property
            get
            { 
                return _lastName;
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                _lastName = value/*.ToLower()*/;
            }
        }
    }
}
