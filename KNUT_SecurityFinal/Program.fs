// For more information see https://aka.ms/fsharp-console-apps

(*
    이 프로그램은 Http 프록시입니다.
    이 프로그램에서 tcp를 통해 
    - 1. 일반 http 규격의 비보호 상태와, (평문)
    - 2. payload가 AES등의 대칭 암호화가 진행된 상태로 전달된 규격,
    - 3. payload가 RSA등의 비대칭 암호화가 진행된 상태로 전달된 규격,
    - 4. 그리고 최종적으로 웹(https)에서는 어떤 것을 쓰는지 조사하고,
    - 5. 아주 미약하게나마 양자내성을 가진 알고리즘과 미래도 논해보려 합니다.

    > 본 프로그램은 F#으로 작성되었습니다.
    > 본 프로그램은 .NET 8.0을 기반으로 작성되었습니다

    - 작성자: LuticaCANARD
    https://github.com/LuticaCANARD/KNUT_SecurityFinal
*)

printfn "Hello from F#"
