﻿using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего объекта
        public abstract IEnumerator GetEnumerator();
    }
    
    // Конкретные Коллекции предоставляют один или несколько методов для
    // получения новых экземпляров итератора, совместимых с классом коллекции.
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        private bool _direction;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        
        public List<string> GetItems()
        {
            return _collection;
        }
        
        public void AddItem(string item)
        {
            _collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}