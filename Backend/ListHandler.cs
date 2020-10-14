using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoginForm.Backend
{
    static class ListHandler
    {
        #region Sort the List
        public static List<User> QuickSort(List<User> list, int left, int right)
        {
            int pivot; // Index of our pivot point

            if (left < right) {
                pivot = Partition(list, left, right);

                if (pivot > 1) // Sort the first half
                    QuickSort(list, left, pivot - 1);

                if (pivot + 1 < right) // Sort the second half
                    QuickSort(list, pivot + 1, right);
            }

            return list;
        }

        private static int Partition(List<User> list, int left, int right)
        {
            User pivot;
            pivot = list[left];

            while (true) {
                // list[left] < pivot
                while (Comparer<string>.Default.Compare(list[left].Email, pivot.Email) < 0)
                    left++;

                // list[right] > pivot
                while (Comparer<string>.Default.Compare(list[right].Email, pivot.Email) > 0)
                    right--;

                if (left < right) {
                    User temp = list[right];
                    list[right] = list[left];
                    list[left] = temp;
                } else
                    return right;
            }
        }
        #endregion

        #region Search in the List
        public static int BinaryRecursiveSearch(List<User> list, int left, int right, string item) // O(logn)
        {
            // If left > right, the item cannot be found, so we return -1
            if (left > right)
                return -1;

            int mid = left + (right - left) / 2; // We find the element in the middle

            // If the element is present at the middle itself, return the index
            if (Comparer<string>.Default.Compare(list[mid].Email, item) == 0)
                return mid;
            // If element is smaller than mid, then it can only be present in left subarray 
            else if (Comparer<string>.Default.Compare(list[mid].Email, item) > 0)
                return BinaryRecursiveSearch(list, left, mid - 1, item);
            else // Else the element can only be present in right subarray
                return BinaryRecursiveSearch(list, mid + 1, right, item);
        }
        #endregion

        #region Load & Save the List
        static string dir = @"..\..\..\Backend\";
        static string serializationFile = Path.Combine(dir, "usersList.json");

        public static List<User> LoadList()
        {
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                try {
                    List<User> users = (List<User>)bformatter.Deserialize(stream);
                    return QuickSort(users, 0, users.Count - 1);
                } catch (Exception) {
                    return new List<User>();
                }
            }
        }

        public static void SaveList(List<User> users)
        {
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, users);
            }
        }
        #endregion
    }
}
