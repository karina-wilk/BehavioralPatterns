using IteratorPattern.ConcreteIterators;
using IteratorPattern.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Collections
{
    public class SecretCollection : IteratorAggregate
    {
        List<SecretValue> items = new List<SecretValue>();
        bool reverseOrder = false;

        public void ReverseOrder() => reverseOrder = !reverseOrder;
        public void AddItem(SecretValue i) => items.Add(i);
        public void AddItem(string value, bool isSecret) 
            => items.Add(new SecretValue() {CannotBeShown = isSecret, Word = value });
        public List<SecretValue> GetAll() => items;
        public List<SecretValue> GetAllNotForbiden() => items.Where(c => c.CannotBeShown == false).ToList();

        public override IEnumerator GetEnumerator()
        {
            return new OmitPiotrekSecretIterator(this, reverseOrder);
        }
    }
}
