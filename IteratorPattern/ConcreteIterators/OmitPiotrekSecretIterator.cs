using IteratorPattern.Collections;
using IteratorPattern.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.ConcreteIterators
{
    public class OmitPiotrekSecretIterator : Iterator
    {
        private SecretCollection collection;
        private List<SecretValue> allButPiotrek
        {
            get => collection.GetAll().Where(c => !c.Word.Contains("Piotrek")).ToList();
        }

        private int position = -1;
        private bool reverse = false;

        public OmitPiotrekSecretIterator(SecretCollection collection, bool reverse = false)
        {
            this.collection = collection;

            this.reverse = reverse;

            if (reverse)
            {
                position = allButPiotrek.Count;
            }
        }

        public override object Current() => allButPiotrek[position];

        public override int Key() => position;

        public override bool MoveNext()
        {
            var tempPosition = position + (reverse ? -1 : 1);
            if(allButPiotrek.Count > tempPosition && tempPosition >= 0)
            {
                position = tempPosition;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            var itemsNotSecretCount = allButPiotrek.Count;
            if (reverse && itemsNotSecretCount > 0)
            {
                position = itemsNotSecretCount - 1;
            }
            else
            {
                position = 0;
            }
        }
    }
}
