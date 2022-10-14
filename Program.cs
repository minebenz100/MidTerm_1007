enum Menu {
    Register = 1,
    Login,
    GetListPersons
}
enum Register{
    CurrentStudent=1,
    Student,
    Teacher
}

class Program {

    static PersonList personList;

    static void Main(string[] args) {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen() {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void PrintMenuRes() {
        Console.Clear();
        PrintListRes();
        InputResFromKeyboard();
    }

    static void PrintListMenu() {
        Console.WriteLine("Welcome to application");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Registration :");
        Console.WriteLine("2. Login : ");
        Console.WriteLine("3. Get List Persons :");
        Console.WriteLine("****************************************************");
    }
static void PrintListRes() {
        Console.WriteLine("Welcome to Registration");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. CurrentStudent");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("****************************************************");
    }
    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }
    static void InputResFromKeyboard() {
        Console.Write("Please input Register:");
        Register register = (Register)(int.Parse(Console.ReadLine()));

        RegisterMenu(register);
    }

    static void PresentMenu(Menu menu) {
        switch (menu) {
            case Menu.Register:
                PrintMenuRes();
                break;
            case Menu.Login:
                ShowInputLoginScreen();
                break;
            case Menu.GetListPersons:
                ShowPersons();
                break;
            default:
                break;
        }
    }
     static void ShowPersons() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }
static void RegisterMenu(Register register) {
        switch (register) {
            case Register.CurrentStudent:
                ShowInputRegistrationCurrentStudentScreen();
                break;
            case Register.Teacher:
                ShowInputRegistrationNewTeacherScreen();
                break;
            case Register.Student:
                ShowInputRegistrationStudentScreen();
                break;
            default:
                break;
        }
    }
 
    static void ShowInputRegistrationCurrentStudentScreen(){
        Console.Clear();
        PrintHeaderRegisterCurrentStudent();
        int totalNewCurrentStudent = TotalNewCurrentStudent();
        inputNewCurrentStudentFromKeyboard(totalNewCurrentStudent);
    }

    static void ShowInputRegistrationNewTeacherScreen() {
        Console.Clear();

        PrintHeaderRegistrationTeacher();

        int totalNewTeacher = TotalNewTeacher();
        inputNewTeacherFromKeyboard(totalNewTeacher);
    }

    static void ShowInputRegistrationStudentScreen() {
        Console.Clear();
        PrintHeaderRegisterStudent();
        int totalNewStudent = TotalNewStudent();
        InputNewStudentFromKeyboard(totalNewStudent);
    }
    static void ShowInputLoginScreen(){
        Console.Clear();
        Console.WriteLine("Login");
        Console.WriteLine("*********************");
    }

    static void PrintHeaderRegistrationTeacher() {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*********************");
    }

    static int TotalNewStudent() {
        Console.Write("Input Total new Student: ");

        return int.Parse(Console.ReadLine());
    }

    static int TotalNewTeacher() {
        Console.Write("Input Total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }
    static int TotalNewCurrentStudent() {
        Console.Write("Input Total new CurrentStudent: ");

        return int.Parse(Console.ReadLine());
    }
    static void InputNewStudentFromKeyboard(int totalNewStudent) {
        for(int i = 0; i < totalNewStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputGrade() 
            );

            Program.personList.AddNewPerson(student);
        }

        BackToMainMenu();
    }

    static void inputNewTeacherFromKeyboard(int totalNewTeacher) {
          for(int i = 0; i < totalNewTeacher; i++) {
            Console.Clear();
            PrintHeaderRegistrationTeacher();

            Teacher teacher = new Teacher(InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputJobtitle()
            );

            Program.personList.AddNewPerson(teacher);
        }

        BackToMainMenu();
    }
    static void PrintHeaderRegisterCurrentStudent() {
        Console.WriteLine("Register New CurrentStudent");
        Console.WriteLine("*********************");
    }
    static void inputNewCurrentStudentFromKeyboard(int totalNewCurrentStudent) {
          for(int i = 0; i < totalNewCurrentStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterCurrentStudent();

            CurrentStudent currentStudent = new CurrentStudent(InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputStudentID()
            );

            Program.personList.AddNewPerson(currentStudent);
        }

        BackToMainMenu();
    }
    static void PrintHeaderRegisterStudent() {
        Console.WriteLine("Register New Student");
        Console.WriteLine("*********************");
    }

    static void BackToMainMenu() {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PreparePersonListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }

    static string InputName() {
        Console.WriteLine("Mr./ Mrs./ Ms. ");
        Console.Write("Name : ");

        return Console.ReadLine();
    }

    static string InputSurname() {
        Console.Write("Surname : ");

        return Console.ReadLine();
    }

    static string InputAge() {
        Console.Write("Age : ");

        return Console.ReadLine();
    }

    static string InputAllergy() {
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

    static string InputReligion() {
        Console.WriteLine("Buddhist / Christian / Islam / Other");
        Console.Write("Religion : ");

        return Console.ReadLine();
    }
    static string InputStudentID() {
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }
    static string InputGrade() {
        Console.WriteLine("M4 / M5 /M6");
        Console.Write("Grade : ");

        return Console.ReadLine();
    }
    static string InputJobtitle() {
        Console.WriteLine("Dean/ Head of department /full-time teacher");
        Console.Write("Jobtitle : ");

        return Console.ReadLine();
    }

}
