namespace ColdWorkingSensors

{

    struct Hit
    {

        public int Temperature;

        public int Row;

        public int Col;

        public Hit(int temperature, int row, int column)

        {

            this.Temperature = temperature;

            this.Row = row;

            this.Col = column;

        }

    }


    struct Reading
    {

        public int Temperature;

        public bool Fault;


        public Reading(int temperature, bool fault)

        {

            this.Temperature = temperature;

            this.Fault = fault;

        }

    }


    internal class Program
    {

        static void Main(string[] args)

        {

            Reading[,] readings = {
                { new Reading(20, true), new Reading(15, false) },
                { new Reading(80, false), new Reading(22, true )}
            };
            ColderThan(readings, 30);        }

            static Hit[] ColderThan(Reading[,] readings, int limit)

            {

                int rows = readings.GetLength(0);

                int columns = readings.GetLength(1);

                int resultArrayLength = 0;


                for (int rowIndex = 0; rowIndex < rows; ++rowIndex)

                {

                    for (int columnIndex = 0; columnIndex < columns; ++columnIndex)

                    {

                        Reading currentReading = readings[rowIndex, columnIndex];

                        if (!currentReading.Fault && currentReading.Temperature < limit)

                        {

                            resultArrayLength++;

                        }

                    }

                }


                int resultCurrentIndex = 0;

                Hit[] result = new Hit[resultArrayLength];


                for (int rowIndex = 0; rowIndex < rows; ++rowIndex)

                {

                    for (int columnIndex = 0; columnIndex < columns; ++columnIndex)

                    {

                        Reading currentReading = readings[rowIndex, columnIndex];

                        if (!currentReading.Fault && currentReading.Temperature < limit)

                        {

                            result[resultCurrentIndex++] = new Hit(currentReading.Temperature, rowIndex, columnIndex);

                        }

                    }

                }


                return result;

            }

        }

    }