class Student {

    public void DisplayMarks(params int[] marks) {

        for(int i = 0; i < marks.Length; i++) {
            Console.WriteLine("Marks " + (i+1) + ": " + marks[i]);

        }

        //assign value from local function to variable
        double avgMarks = getAverageMarks(marks);

        Console.WriteLine("Average Marks: " + avgMarks);

        //create static local function to get average of students marks
        static double getAverageMarks(params int[] marks) {
            double sum = 0;
            double avg;

            for(int i=0; i<marks.Length; i++) {
                sum += marks[i];
            }

            avg = (double) sum / marks.Length;

            return avg;
        }

    }

    class Program {

        static void Main() {

            //create an object
            Student s = new Student();

            //call method to list grades and display average
            s.DisplayMarks(80,45,71);

            Console.ReadKey();
        }

    }

}