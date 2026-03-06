using System;
using System.Xml.Serialization;

// README.md를 읽고 아래에 코드를 작성하세요.

Status currentStatus = Status.Idle;
string currentStat = currentStatus.ToString();


string choice;
string statusChoice;

void ShowStatus()  // 현재 상태 출력기
{
    Console.WriteLine(currentStat);
}

void PrintFirstChoices() // 처음 선택지 로드
{
    Console.WriteLine();
    Console.WriteLine("1. 상태변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");
    Console.Write("선택: ");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            ChangeStatus();
            break;
        case "2":
            ShowStatusList();
            PrintFirstChoices();
            break;
        case "3":
            ShowCurrentAct();
            PrintFirstChoices();
            break;
        case "4":
            Exit();
            break;
    }
}

void ChangeStatus()  // 1. 상태 변경 
{
    Console.Write("변경할 상태 번호 입력 (0-5): ");
    statusChoice = Console.ReadLine();
    switch (statusChoice)
    {
        case "0":
            currentStatus = Status.Idle;
            Console.WriteLine("현재 상태가 Idle(으)로 변경되었습니다.");
            break;
        case "1":
            currentStatus = Status.Walking;
            Console.WriteLine("현재 상태가 Walking(으)로 변경되었습니다.");
            break;
        case "2":
            currentStatus = Status.Running;
            Console.WriteLine("현재 상태가 Running(으)로 변경되었습니다.");
            break;
        case "3":
            currentStatus = Status.Jumping;
            Console.WriteLine("현재 상태가 Jumping(으)로 변경되었습니다.");
            break;
        case "4":
            currentStatus = Status.Attacking;
            Console.WriteLine("현재 상태가 Attacking(으)로 변경되었습니다.");
            break;
        case "5":
            currentStatus = Status.Dead;
            Console.WriteLine("현재 상태가 Dead(으)로 변경되었습니다.");
            break;
    }
    Console.WriteLine();
    Console.WriteLine($"현재 상태: {currentStat}");
    PrintFirstChoices();

}

void ShowStatusList()  // 2. 상태 목록 출력기
{
    Console.WriteLine();
    Console.WriteLine("=== 상태 목록 ===");
    Console.WriteLine("Idle = 0");
    Console.WriteLine("Walking = 1");
    Console.WriteLine("Running =2");
    Console.WriteLine("Jumping = 3");
    Console.WriteLine("Attacking = 4");
    Console.WriteLine("Dead = 5");
    Console.WriteLine();
    Console.WriteLine($"현재 상태: {currentStat}");
}

void ShowCurrentAct()  // 3. 현재 행동 보기
{
    if (currentStat == "Idle")
    {
        Console.WriteLine("[행동] 현재 아이들 상태입니다. 아이들을 확인하세요");
    }
    else if (currentStat == "Walking")
    {
        Console.WriteLine("[행동] 현재 걷는 중입니다. 계속 걸으세요");
    }
    else if (currentStat == "Running")
    {
        Console.WriteLine("[행동] 현재 뛰는 중입니다. 호흡 맞추세요");
    }
    else if (currentStat == "Jumping")
    {
        Console.WriteLine("[행동] 현재 점핑 중입니다. 점핑하세요");
    }
    else if (currentStat == "Attacking")
    {
        Console.WriteLine("[행동] 현재 공격 중입니다. 급소를 노리세요");
    }
    else
    {
        Console.WriteLine("[행동] 현재 사망 중입니다.");
    }
}


void Exit()  // 4. 종료
{
    Console.WriteLine();
    Console.WriteLine("프로그램 종료띠");
    return;
}





Console.WriteLine("=== 캐릭터 상태 관리 ===");
Console.WriteLine($"현재 상태: {currentStat}");
PrintFirstChoices();






enum Status  // Status 열거
{
    Idle, // 0
    Walking,  // 1  
    Running,  // 2
    Jumping,  // 3
    Attacking,  // 4
    Dead  // 5
}





