namespace MatrixTask
{
    using System;
    class MatrixMain
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(3, 3);

            if (matrix)
            {
                Console.WriteLine("Won't print");
                Console.WriteLine("Here there are no non-zero values");
            }

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            if (matrix)
            {
                Console.WriteLine("This will print");
            }

            Matrix<int> anotherMat = new Matrix<int>(3, 3);

            anotherMat[0, 0] = 1;
            anotherMat[0, 1] = 2;
            anotherMat[0, 2] = 3;
            anotherMat[1, 0] = 4;
            anotherMat[1, 1] = 5;
            anotherMat[1, 2] = 6;
            anotherMat[2, 0] = 7;
            anotherMat[2, 1] = 8;
            anotherMat[2, 2] = 9;

            Console.WriteLine(matrix + anotherMat);
            Console.WriteLine(matrix - anotherMat);
            Console.WriteLine(matrix * anotherMat);
        }
    }
}
