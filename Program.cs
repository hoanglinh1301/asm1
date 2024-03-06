 #List : mixed types
def inputNumber(promt):
    while True:
     try:
        magicNumber = float(input( promt ))
        return magicNumber
     except Exception:
        print("du lieu bi loi!")
def calculate_gpa():
    product = 0
    for i in range(0,len(subjects)):
        product += grades[i]*credits[i]
    return product / (sum(credits))
        
        
        
subjects = ["C#","Python"] #sub
credits = [] #credit
grades = [] #grade
 # Print the student's name and GPA.
student_name = input("Nhập tên sinh viên: ")
for subject in subjects:
    grade = inputNumber(f"Input grade for {subject}: ")
    grades.append(grade) 
    credit = inputNumber(f"Input credit for {subject}: ")
    credits.append(credit)

totalcredits = sum(credits)
print(f"tong so tin chi cua ban {student_name} la:{totalcredits} ")
totalgrades = sum(grades)
print(f"tong so diem cua ban {student_name} la:{totalgrades}")
print(calculate_gpa())
# Calculate GPA
gpa = calculate_gpa()
print(f"{student_name}'s GPA is: {gpa}")
with open('Linh.txt','w') as file:
      file.write(f'{student_name}, {credits}, {grades}, {gpa}') 
