using System.Collections;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Возвращает ключ текущего элемента
        public abstract int Key();
        
        // Возвращает текущий элемент.
        public abstract object Current();
        
        // Переходит к следующему элементу.
        public abstract bool MoveNext();
        
        // "Перематывает" Итератор к первому элементу.
        public abstract void Reset();
    }

    // Конкретные Итераторы реализуют различные алгоритмы обхода. Эти классы
    // постоянно хранят текущее положение обхода.
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        
        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации.
        private int _position = -1;
        
        private readonly bool _reverse;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }
        
        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }
        
        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}