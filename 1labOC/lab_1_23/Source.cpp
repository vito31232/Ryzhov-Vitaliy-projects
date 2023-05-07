// Рыжов В.Р., УИС-312
// 23 вариант 
// Получение информации о количестве логических процессоров, заданной группы
#include <iostream>
#include <windows.h>

int main(int argc, char* argv[])
{
    if (argc < 2) {
        std::cerr << "Usage: " << argv[0] << " <processor_group_number>" << std::endl;
        return 1;
    }

    DWORD groupNumber = atoi(argv[1]);
    DWORD maxProcessorCount = GetMaximumProcessorCount(groupNumber);
    std::cout << "Max processor count for group " << groupNumber << ": " << maxProcessorCount << std::endl;
    return 0;
}