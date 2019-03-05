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
    public class OmitSecretIterator : Iterator
    {
        private SecretCollection collection;

        private int position = -1;
        private bool reverse = false;

        public OmitSecretIterator(SecretCollection collection, bool reverse = false)
        {
            this.collection = collection;
            this.reverse = reverse;

            if (reverse)
            {
                position = collection.GetAllNotForbiden().Count;
            }
        }

        public override object Current() =>  collection.GetAllNotForbiden()[position];

        public override int Key() => position;

        public override bool MoveNext()
        {
            var tempPosition = position + (reverse ? -1 : 1);
            if(collection.GetAllNotForbiden().Count > tempPosition && tempPosition >= 0)
            {
                position = tempPosition;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            var itemsNotSecretCount = collection.GetAllNotForbiden().Count;
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
