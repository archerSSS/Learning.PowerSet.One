﻿using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class PowerSet<T>
    {

        public int size;
        public T[] slots;
        
        public PowerSet()
        {
            size = 20000;
            slots = new T[size];
            for (int i = 0; i < size; i++)
                slots[i] = default(T);
        }

        public int Size()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                if (slots[i] != null && !slots[i].Equals(default(T)))
                    count++;
            if (count != 0) return count; 
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
                slot ++;
            }
            if (memSlot != -1) slots[memSlot] = value;

        }

        public bool Get(T value)
        {
            //if (value == null) return false;
            if (value != null)
            {
                int slot = HashFun(value);
                for (int i = 0; i < size; i++)
                {
                    if (slot >= size) slot = 0;
                    if (slots[slot] != null)
                        if (slots[slot].Equals(value)) return true;
                    slot ++;
                }
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
                        return true;
                    }
                slot ++;
            }
            return false;
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            PowerSet<T> interset = new PowerSet<T>();
            if (Size() != 0 && set2.Size() != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if (slots[i] == null) continue;
                    else if (slots[i].Equals(default(T))) continue;
                    if (set2.Get(slots[i])) interset.Put(slots[i]);
                }
                if (interset.Size() != 0) return interset;
            }
            return null;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            PowerSet<T> unity = new PowerSet<T>();
            if (Size() != 0 || set2.Size() != 0)
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
                for (int i = 0; i < size; i++)
                {
                    if (slots[i] != null)
                        diff.Put(slots[i]);
                }
                for (int i = 0; i < size; i++)
                {
                    if (set2.slots[i] != null)
                        if (diff.Get(set2.slots[i])) diff.Remove(set2.slots[i]);
                        else diff.Put(set2.slots[i]);
                }
                if (diff.Size() != 0) return diff;
            }
            return null;
            
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            if (Size() > set2.Size())
            {
                if (set2.Size() == 0) return true;
                for (int i = 0; i < size; i++)
                {
                    if (set2.slots[i] != null && !set2.slots[i].Equals(default(T)))
                        if (!Get(set2.slots[i])) break;
                    if (i == size - 1) return true;
                }   
            }
            return false;
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
    }
}