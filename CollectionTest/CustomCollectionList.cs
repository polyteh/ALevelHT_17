using CollectionTest.SimpleClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    public class CustomCollectionList<T> : IEnumerable<T>
    {
        // storage list
        private List<T> customCollectionList;

        public CustomCollectionList()
        {
            customCollectionList = new List<T>();
        }
        // add new item
        public void Add(T newItem)
        {
            customCollectionList.Add(newItem);
        }
        // remove item by ID 
        public bool RemoveByID(string removeItemID)
        {
            var itemToDelete = customCollectionList.Find((x)=>((IInfo)x).ID==removeItemID);
            if (customCollectionList.Remove(itemToDelete))
            {
                return true;
            }
            return false;
        }
        // return number of elements
        public int NumberOfItems()
        {
            return customCollectionList.Count;
        }
        // return List of elements with accordance with the search criteria
        public List<T> FindAll(Predicate<T> searchCriteria)
        {
            List<T> findElements = customCollectionList.FindAll(searchCriteria);
            if (findElements.Count!=0)
            {
                return findElements;
            }
            return null;
        }
        // search with reflection. Search criteria + sorting
        //How can I define keyProperty correctly in the Main?
        public IEnumerable<T> FindItems(Predicate<T> searchCriteria, string keyProperty)
        {
            var type = typeof(T);
            var sortProperty = type.GetProperty(keyProperty);
            List<T> findElements = customCollectionList.FindAll(searchCriteria).OrderBy(p => sortProperty.GetValue(p, null)).ToList();
            Console.WriteLine("inside find");

            for (int i = 0; i < findElements.Count; i++)
            {
                if (i == findElements.Count)
                {
                    yield break;
                }
                else
                {
                    yield return findElements[i];
                }
            }
        }
        // search with criteria and sort elements. Return with iterator spcific amount of items
        public IEnumerable<T> FindItems<TKey>(Predicate<T> searchCriteria, Func<T, TKey> keySelector, int itemCount)
        {         
            List<T> findElements = customCollectionList.FindAll(searchCriteria).OrderBy(keySelector).ToList();
            int curItemCount = 0;
            for (int i = 0; i < findElements.Count; i++)
            {
                if ((i == findElements.Count)||(curItemCount==itemCount))
                {
                    yield break;
                }
                else
                {
                    ++curItemCount;
                    yield return findElements[i];
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return customCollectionList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return customCollectionList.GetEnumerator();
        }
    }
}
