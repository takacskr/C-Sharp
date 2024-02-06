using System;

namespace MatrixApp
{
    // Matrix osztály definiálása
    class Matrix
    {
        int[,] matrix; // Int típusú 2D tömb a mátrix tárolására

        // Konstruktor, létrehoz egy n x m méretű üres mátrixot
        // Ez a konstruktor egy n sor és m oszlop méretű
        // egész számokból álló mátrixot hoz létre
        public Matrix(int n, int m)
        {
            matrix = new int[n, m]; // Mátrix inicializálása
        }

        // Az osztály két tulajdonsága (N és M) meghatározza
        // a mátrix sorainak (N) és oszlopainak (M) számát,
        // a matrix tömb GetLength metódusának segítségével
        // N property: visszaadja a mátrix sorainak számát
        public int N
        {
            get { return matrix.GetLength(0); } // Sorok számának lekérdezése
        }

        // M property: visszaadja a mátrix oszlopainak számát
        public int M
        {
            get { return matrix.GetLength(1); } // Oszlopok számának lekérdezése
        }

        // Indexer: lekérdezés és beállítás az indexek alapján
        // Az osztály egy indexelőt (this) tartalmaz, amely lehetővé teszi a mátrix elemeinek
        // hozzáférését és beállítását. Ez az indexelő lehetővé teszi, hogy a mátrix elemeit
        // egy adott sor- és oszlopindex kombinációval lekérjük vagy beállítsuk.

        // A this kulcsszó az adott osztály egy példányát vagy objektumát jelöli.
        // A this ebben az esetben a Matrix osztály egy példányára vonatkozik, azaz azon objektumra,
        // amelynek az indexelőjét használjuk.
        // Az indexelő egy adott idxn és idxm indexpárhoz tartozó értéket ad vissza vagy állít be a matrix tömbben.
        public int this[int idxn, int idxm]
        {
            get { return matrix[idxn, idxm]; } // Érték lekérdezése
            set { matrix[idxn, idxm] = value; } // Érték beállítása
        }

        // Operator overload (+): két mátrix összeadása
        static public Matrix operator +(Matrix lhs, Matrix rhs)
        {
            // Ellenőrzés: a két mátrix méreteinek egyezése
            if (lhs.N != rhs.N || lhs.M != rhs.M) return null; // Ha nem egyezik, null visszaadása

            Matrix result = new Matrix(lhs.N, lhs.M); // Eredmény mátrix létrehozása

            // Mátrixok összeadása
            for (int i = 0; i < lhs.N; ++i)
            {
                for (int j = 0; j < lhs.M; ++j)
                {
                    result[i, j] = lhs[i, j] + rhs[i, j]; // Összeadás és eredmény beállítása
                }
            }

            return result; // Eredmény visszaadása
        }

        // Random mátrix létrehozása
        // Ez a metódus statikus, mert ezáltal meghívható a Matrix osztálytól függetlenül,
        // közvetlenül az osztály nevével, anélkül, hogy először példányt kellene létrehozni az osztályból
        public static Matrix CreateRandomMatrix(int n, int m)
        {
            Random random = new Random(); // Random objektum létrehozása
            Matrix matrix = new Matrix(n, m); // Mátrix létrehozása

            // Véletlenszerű értékek beállítása
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    matrix[i, j] = random.Next(1, 101); // Véletlenszerű érték beállítása 1 és 100 között
                }
            }

            return matrix; // Mátrix visszaadása
        }

    }

    // PrintMatrix osztály definiálása
    class PrintMatrix
    {
        int[,] matrix; // Int típusú 2D tömb a mátrix tárolására

        // Konstruktor: átmásolja a mátrixot a saját tömbbe
        public PrintMatrix(Matrix matrix)
        {
            this.matrix = new int[matrix.N, matrix.M]; // Tömb létrehozása a megadott méretben

            // Mátrix másolása a saját tömbbe
            for (int i = 0; i < matrix.N; i++)
            {
                for (int j = 0; j < matrix.M; j++)
                {
                    this.matrix[i, j] = matrix[i, j]; // Érték másolása
                }
            }
        }

        // Mátrix kiírása konzolra
        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // Érték kiírása
                }
                Console.WriteLine(); // Sortörés
            }
        }
    }

    // Program belépési pontja
    internal class Program
    {
        // Main metódus
        static void Main()
        {
            // Véletlenszerű mátrixok létrehozása
            Matrix matrix1 = Matrix.CreateRandomMatrix(3, 4);
            Matrix matrix2 = Matrix.CreateRandomMatrix(3, 4);

            // Mátrixok összeadása
            Matrix resultMatrix = matrix1 + matrix2;

            // Eredmény kiírása
            PrintMatrix printer = new PrintMatrix(resultMatrix);
            printer.Print();
        }
    }
}
