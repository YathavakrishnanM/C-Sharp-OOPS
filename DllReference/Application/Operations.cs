using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CollegeDetails;

namespace Application
{
    // Static Class
    public static class Operations
    {

        //Local or Global Object creation
        static StudentDetails currentLoggedInStudent;

        //Static list creation

        static List<StudentDetails> studentList=new List<StudentDetails>();

        static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();

        static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();


        public static void MainMenu(){
            Console.WriteLine("***___Welcome to Syncfusion ");
            

            string mainChoice="yes";

            do
            {
                //Need to show the main menu option
                Console.WriteLine("MainMenu\n    1. Registration\n    2. Login\n    3. Departmentwise Seat Availability\n    4. Exit");
                //Need to get input from user and validate.
                Console.WriteLine("Select the Option: ");
                int mainOption = int.Parse(Console.ReadLine());
                //Need to create main menu structure

                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("*********Student Registration*********");
                            StudentRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("*********Student Login*********");
                            StudentLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("*********Departmentwise Seat availability*********");
                            DepartmentwiseSeatAvailability();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Application Exited Successfully");
                            mainChoice="no";
                            break;
                        }
                }
                //Need to iterate until the option is exit
            } while (mainChoice=="yes");
        }//MainMenu ends

        //Student Registration
        public static void StudentRegistration(){

            //Need to get required details
            Console.Write("Please enter your name :");
            string studentName=Console.ReadLine();

            Console.Write("Please enter the Father name :");
            string fatherName=Console.ReadLine();

            Console.Write("Please enter your Date Of Birth in dd/MM/yyyy  format : ");
            DateTime dob=DateTime.Parse(Console.ReadLine());

            Console.Write("Please enter your gender Male/Female/Transgender : ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            Console.Write("Enter the mark obtained in Physics : ");
            int physicsMark=int.Parse(Console.ReadLine());

             Console.Write("Enter the mark obtained in Chemistry : ");
            int chemistryMark=int.Parse(Console.ReadLine());

             Console.Write("Enter the mark obtained in Maths : ");
            int mathsMark=int.Parse(Console.ReadLine());

            //Need to create an object
            StudentDetails student=new StudentDetails(studentName,fatherName,dob,gender,physicsMark,chemistryMark,mathsMark);

            //Need to add in the list
            studentList.Add(student);

            //Need to display confirmation message and ID
            Console.WriteLine($"Registration is successfull!.StudentID : {student.StudentID}");
            Console.WriteLine();

        }//Student registration ends

        //Student Login

        public static void StudentLogin(){
            //Need to get ID input
            Console.Write("Enter your StudentID : ");
            string loginID=Console.ReadLine().ToUpper();

            //Validate by its presence in list.
            bool flag=true;
            foreach(StudentDetails student in studentList){
                if(loginID.Equals(student.StudentID)){
                    flag=false;
                    //Current user assigning to global variable
                    currentLoggedInStudent=student;
                    Console.WriteLine("   Login successfully!");
                  
                    //Need to show SubMenu
                    SubMenu();
                    break;
                }
            }

            if(flag){
                System.Console.WriteLine("Invaild ID or ID is not Present");
            }
            //If-not Invalid ID.

        }//student login ends


        //SubMenu
        public static void SubMenu(){
                string subChoice="yes";
                do{
                    Console.WriteLine("******SubMenu******");
                    //Need to show sub menu options
                    Console.WriteLine("Select the Option\n    1. Check Eligibility\n    2. Show Details\n    3. Take Admission\n    4. Cancel Admission\n    5. Show Admission Details\n    6. Exit");
                    
                    //Getting user option
                    Console.Write("Enter the Option : ");
                    int subOption=int.Parse(Console.ReadLine());

                    // Need to create sub menu structure

                    switch(subOption){
                        case 1:{
                            Console.WriteLine("************Check Eligibility************");
                            CheckEligibility();
                            break;
                        }
                        case 2:{
                            Console.WriteLine("************Show Details************");
                            ShowDetails();
                            break;
                        }
                        case 3:{
                            Console.WriteLine("************Take Admission************");
                            TakeAdmission();
                            break;
                        }
                        case 4:{
                            Console.WriteLine("************Cancel Admission************");
                            CancelAdmission();
                            break;
                        }
                        case 5:{
                            Console.WriteLine("************Show Admission Details************");
                            ShowAdmissionDetails();
                            break;
                        }case 6:{
                            Console.WriteLine("Take back to MainMenu");
                            subChoice="no";
                            break;
                        }
                    }
                    //Iterate till end

                }while(subChoice=="yes");
        }//submenu ends


        //CheckEligibility
        public static void CheckEligibility(){
                //Get the cut off value as input
                Console.Write("Enter the cutoff value : ");
                double cutOff=double.Parse(Console.ReadLine());
                //Check Eligible or not
                if(currentLoggedInStudent.CheckEligibility(cutOff)){
                    Console.WriteLine("Student is eligible!");
                }else{
                    Console.WriteLine("Student is not eligible");
                }
        }//CheckEligibility ends

        //Show details
        public static void ShowDetails(){
                //Need to show current student details
                Console.WriteLine($"| StudentId | StudentName | FatherName | DateOfBirth | Gender | PhysicsMark | ChemistryMark | MathsMark |");
                Console.WriteLine($"| {currentLoggedInStudent.StudentID} | {currentLoggedInStudent.StudentName} | {currentLoggedInStudent.FatherName} | {currentLoggedInStudent.DOB} | {currentLoggedInStudent.Gender} | {currentLoggedInStudent.PhysicsMark} | {currentLoggedInStudent.ChemistryMark} | {currentLoggedInStudent.MathsMark}|");

            
            Console.WriteLine();
        }//Showw details end

        //Take admission
        public static void TakeAdmission(){
                //Need to show available department details
                DepartmentwiseSeatAvailability();

                //Ask department ID from user
                Console.Write("Select the department ID : ");
                string departmentID=Console.ReadLine().ToUpper();

                //Check the ID is present or not
                bool flag=true;
                foreach(DepartmentDetails department in departmentList){
                    if(departmentID.Equals(department.DepartmentID)){
                            flag=false;
                            //Check the student is eligble or not
                            if(currentLoggedInStudent.CheckEligibility(75.0)){

                                //Check the seat availability
                                if(department.NumberOfSeats>0){
                                    int count=0;
                                    //Check student already taken any admission
                                    foreach(AdmissionDetails admission in admissionList){
                                        if(currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted)){
                                            count++;

                                        }
                                    }

                                    if(count == 0){
                                        //create admission object

                                        AdmissionDetails admissionTake=new AdmissionDetails(currentLoggedInStudent.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                                        //Reduce the seat count
                                        department.NumberOfSeats--;
                                        //Add to the admission list
                                        admissionList.Add(admissionTake);
                                        //Display admission successful message
                                        Console.WriteLine("you have taken admission succesfully.Admission ID : " + admissionTake.AdmissionID);


                                    }else{
                                        Console.WriteLine("You have already taken an admission");
                                    }
                                   
                                }else{
                                    Console.WriteLine("Seats are not available");
                                }
                                

                            }else{
                                    Console.WriteLine("You are not eligible due to low cutoff");
                            }
                            
                            break;
                    }
                }
                if(flag){
                    Console.WriteLine("Invalid ID");
                }
                
        }//Take addmission end

        //Cancel admission
       
        public static void CancelAdmission(){
            //Check the student is taken any admission and display it.
             bool flag=true;
            foreach(AdmissionDetails admission in admissionList){
                if(currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted)){
                       flag=false;
                        //cancel the found admission
                        admission.AdmissionStatus=AdmissionStatus.Cancelled;
                        //return the seat to department.
                        foreach(DepartmentDetails department in departmentList){
                            if(admission.DepartmentID.Equals(department.DepartmentID)){
                                department.NumberOfSeats++;
                                Console.WriteLine("Admission cancelled successfully");
                                break;
                            }
                        }
                        break;
                }
            }
            if(flag){
                Console.WriteLine("You dont have any admission for cancel");
            }
            

        }//Cancel admission end

        //Show admission details
        public static void ShowAdmissionDetails(){
            //Need to show current logged in student details

            Console.WriteLine($"|  AdmissionID  |  StudentId  |  DepartmentID  |  Admission Date  |  Admission Status  |");

            foreach (AdmissionDetails admission in admissionList)
            {
                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID))
                {
                    Console.WriteLine($"|{admission.AdmissionID}|{admission.StudentID}|{admission.DepartmentID}|{admission.AdmissionDate}|{admission.AdmissionStatus}|");

                }
            }
        }

        //Departmentwise Seat Availability
        public static void DepartmentwiseSeatAvailability(){

            //Need to show all department details
            Console.WriteLine($"|DepartmentID|DepartmentName|NumberOfSeatsAvailable|");
            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"|   {department.DepartmentID}   |     {department.DepartmentName}    |          {department.NumberOfSeats}          |");
            }

            Console.WriteLine();
        }// DepartmentwiseSeatAvailability ends

        // Adding Default Data
        public static void AddDefaultData()
        {
            StudentDetails student1=new StudentDetails("Ravichandran","Ettapparajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
            StudentDetails student2=new StudentDetails("Baskaran","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);

           /* studentList.Add(student1);
            studentList.Add(student2);*/
            //Add multi datas in another way.
            studentList.AddRange(new List<StudentDetails>(){student1,student2});

            DepartmentDetails department1=new DepartmentDetails("EEE",29);
            DepartmentDetails department2=new DepartmentDetails("CSE",29);
            DepartmentDetails department3=new DepartmentDetails("MECH",30);
            DepartmentDetails department4=new DepartmentDetails("ECE",30);

            departmentList.AddRange(new List<DepartmentDetails>(){department1,department2,department3,department4});


            AdmissionDetails admission1=new AdmissionDetails(student1.StudentID,department1.DepartmentID,new DateTime(2022,11,05),AdmissionStatus.Admitted);
            AdmissionDetails admission2=new AdmissionDetails(student2.StudentID,department2.DepartmentID,new DateTime(2024,11,05),AdmissionStatus.Admitted);

            admissionList.AddRange(new List<AdmissionDetails>(){admission1,admission2});

            //Printing the Data

        }
        
    }
}