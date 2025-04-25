# baekjoon
This is an auto push repository for Baekjoon Online Judge created with [BaekjoonHub](https://github.com/BaekjoonHub/BaekjoonHub).
# 백준 알고리즘 문제 풀이 모음 (BOJ Solutions)

이 저장소는 **백준 온라인 저지(BOJ, Baekjoon Online Judge)**의 문제들을 풀이한 코드 모음입니다.  
개인적인 알고리즘 학습 및 실력 향상을 위해 꾸준히 정리하고 있습니다.

---

## 📁 폴더 구조

| 디렉토리 | 설명 |
|----------|------|
| `/Bronze` | 브론즈 난이도 문제 풀이 |
| `/Silver` | 실버 난이도 문제 풀이 (예정 또는 진행 중) |
| `/Gold` | 골드 이상 난이도 문제 풀이 (예정 또는 진행 중) |

---

## 💡 풀이 방식

- **C# 언어**로 풀이 (향후 C++, Java, Python도 확장 예정)
- 한 문제당 하나의 `.cs` 파일
- 각 파일 상단에 문제 번호, 제목, 링크 명시

예시:
```csharp
// 백준 1000번: A + B
// https://www.acmicpc.net/problem/1000

using System;

class Program {
    static void Main() {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        Console.WriteLine(a + b);
    }
}
