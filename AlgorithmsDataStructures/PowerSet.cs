using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    // наследуйте этот класс от HashTable
    // или расширьте его методами из HashTable
    public class PowerSet<T> : HashTable<T>
    {
        public int count;

        public PowerSet() : base(20000, 4)
        {
            count = 0;
        }

        public int Size()
        {
            return count;
            return 0;
        }

        public void Put(T value)
        {
            //if (value == null) return;
            //if (value.Equals(default(T))) return;
            int slot = HashFun(value);
            int memSlot = -1;
            
            for (int i = 0; i < size; i++)
            {
                if (slot >= size) slot = 0;
                if ((slots[slot] == null || slots[slot].Equals(default(T))) && memSlot == -1) memSlot = slot;
                if (slots[slot] != null && slots[slot].Equals(value)) return;
                slot++;
            }
            if (memSlot != -1)
            {
                slots[memSlot] = value;
                count++;
            }
        }

        public bool Get(T value)
        {
            //if (value == null) return false;
            if (value.Equals(default(T))) return true;
            
            int slot = HashFun(value);
            for (int i = 0; i < size; i++)
            {
                if (slot >= size) slot = 0;
                if (slots[slot] != null)
                    if (slots[slot].Equals(value)) return true;
                else if (value == null) return true;
                slot++;
            }
            return false;
        }

        public bool Remove(T value)
        {
            // if (value == null) return false;
            if (value.Equals(default(T))) return false;
            int slot = HashFun(value);

            for (int i = 0; i < size; i++)
            {
                if (slot >= size) slot = 0;
                if (slots[slot] != null)
                    if (slots[slot].Equals(value))
                    {
                        slots[slot] = default(T);
                        count--;
                        return true;
                    }
                slot++;
            }
            return false;
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            PowerSet<T> interset = new PowerSet<T>();
            if (count != 0 && set2.count != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if (slots[i] == null) continue;
                    else if (slots[i].Equals(default(T))) continue;
                    if (set2.Get(slots[i]))
                    {
                        interset.slots[i] = slots[i];
                        interset.count++;
                    }
                }
                    
                        
                if (interset.count != 0) return interset;
            }
            return null;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            PowerSet<T> unity = new PowerSet<T>();
            if (count != 0 || set2.count != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if (slots[i] != null) unity.Put(slots[i]);
                    if (set2.slots[i] != null) unity.Put(set2.slots[i]); 
                }
                return unity;
            }
            return null;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            PowerSet<T> diff = new PowerSet<T>();
            if (set2 != null)
            {
                for (int i = 0; i < slots.Length; i++)
                {
                    if (slots[i] != null)
                        diff.Put(slots[i]);
                }
                for (int i = 0; i < slots.Length; i++)
                {
                    if (set2.slots[i] != null)
                        if (diff.Get(set2.slots[i])) diff.Remove(set2.slots[i]);
                        else diff.Put(set2.slots[i]);
                }
                if (diff.count != 0) return diff;
            }
            return null;
            
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            if (count > set2.count)
            {
                int downcounter = set2.count;
                if (set2.count == 0) return true;
                for (int i = 0; i < size; i++)
                {
                    if (set2.slots[i] != null)
                        if (!Get(set2.slots[i])) break;
                    if (i == size - 1) return true;
                }
                
            }
            return false;
        }


        public PowerSet<T> Diff(PowerSet<T> set2)
        {
            PowerSet<T> diff = new PowerSet<T>();
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null)
                    diff.Put(slots[i]);
            }
            for (int i = 0; i < slots.Length; i++)
            {
                if (set2.slots[i] != null)
                    if (diff.Get(set2.slots[i])) diff.Remove(set2.slots[i]); 
                    else diff.Put(set2.slots[i]);
            }
            return diff;
        }
    }

    public class HashTable<T>
    {
        public int size;
        public int step;
        public T[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new T[size];
            for (int i = 0; i < size; i++)
                slots[i] = default(T);
        }

        public int HashFun(T value)
        {
            int nx = 0;
            if (size > 0 && value != null)
            {
                if (value.GetType() == typeof(string))
                {
                    char[] chars = Convert.ToString(value).ToCharArray();
                    for (int i = 0; i < chars.Length - 1; i++)
                        nx += Convert.ToInt32(chars[i]);
                }
                else nx = value.GetHashCode();
                if (nx < 0) return (nx * -1) % size;
                return nx % size;
            }
            return 0;
        }

        public int SeekSlot(T value)
        {
            int nx = HashFun(value);

            for (int i = 0; i < size; i++)
            {
                if (slots[nx] == null) return nx;
                else nx += step;
                if (nx >= size) nx = nx % size;
            }
            return -1;
        }

        public int Put(T value)
        {
            int nx = SeekSlot(value);
            if (nx == -1) return -1;
            slots[nx] = value;
            return nx;
        }

        public int Find(string value)
        {
            for (int i = 0; i < size; i++)
                if (slots[i].Equals(value)) return i;
            return -1;
        }
    }
}