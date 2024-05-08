namespace LanguagesTask
{
    public static class Rotation
    {
        public static T[] RotateArray<T>(T[] array, int positions)
        {
            T[] rotatedArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                rotatedArray[(i + positions) % array.Length] = array[i];
            }
            return rotatedArray;
        }
    }
}
