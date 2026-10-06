# 성경2PPT

> 성경 구절을 PPT로 만들어주는 프로그램

<p align="center"><img src="https://user-images.githubusercontent.com/4927894/59970937-1377a600-95ad-11e9-93b4-66eed61dd932.png" alt="성경2PPT 스크린샷"></p>
<p align="center">⬇️</p>
<p align="center"><img src="https://user-images.githubusercontent.com/4927894/97580541-caecba00-1a36-11eb-9135-979d7e68dc16.png" alt="성경2PPT로 만든 PPT 스크린샷"></p>


## 사용 성경 목록
| 소스 | 언어 | 성경 |
| --- | --- | --- |
| GOODTV 성경 | 한국어 | 개역개정, 개역한글, 공동번역, 새번역, 표준새번역, 현대인의성경, 우리말성경, KJV흠정역 |
| GOODTV 성경 | 영어 | NIV, NASB, ESV, KJV |
| GOODTV 성경 | 일본어 | 구어체, 신공동역 |
| GOODTV 성경 | 중국어 | 번체, 간체 |
| GOODTV 성경 | 기타 | 히브리어(구약), 헬라어(신약), RVR95(스페인어) |
| 갓피아 성경 | 한국어 | 개역개정, 개역한글, 새번역, 쉬운성경, 현대인의성경 |
| 갓피아 성경 | 기타 | NIV, 히브리어(구약), 헬라어(신약) |
| YouVersion 성경 | 한국어 | 개역한글, 새번역, 현대인의 성경, 읽기 쉬운 성경, 우리말성경, 평양말 NLT |
| YouVersion 성경 | 기타 | 영어, 일본어, 중국어(번체, 간체), 히브리어, 헬라어, 스페인어 번역본 (bible.com에서 제공하는 전체 목록) |


## 성경 구절 입력 방법

![성경2PPT 성경 구절 입력 칸 강조 스크린샷](https://user-images.githubusercontent.com/4927894/36576619-1bbd85aa-1895-11e8-9d3c-7b4a58cf807f.png)

**성경 구절 입력 칸**에 **성경 구절**을 아래 형식으로 입력하면 PPT를 만들 수 있습니다.
여러 **성경 구절**을 PPT로 만드려면 띄어쓰기(<kbd>Space</kbd>)로 구분해서 입력하세요.

### 형식

```
책_이름_약자[시작_장[:시작_절][-[끝_장[:끝_절]|끝_절]]]
```

### 예시

| 성경 구절 | 설명 |
| --- | --- |
| `창` | 창세기 전체 |
| `창1` | 창세기 1장 전체 |
| `롬1-3` | 로마서 1장 1절 - 3장 전체 |
| `레1-3:9` | 레위기 1장 1절 - 3장 9절 |
| `전1:3` | 전도서 1장 3절 |
| `스1:3-9` | 에스라 1장 3절 - 1장 9절 |
| `사1:3-3:9` | 이사야 1장 3절 - 3장 9절 |


## 템플릿

![성경2PPT 템플릿 스크린샷](https://user-images.githubusercontent.com/4927894/36580193-9972bece-18aa-11e8-93f2-035283e1a387.png)

**성경2PPT**는 PPT를 만들 때 **템플릿**을 사용합니다.
**템플릿**을 꾸미고 좋아하는 스타일로 PPT를 만드세요!

### 기능

* **치환자**: **템플릿**에 텍스트로 **치환자**를 사용하면
    반복되는 내용을 자동으로 입력할 수 있습니다.

    | 치환자 | 내용 | *접미사* 지원 |
    | --- | --- | :---: |
    | `[TITLE]` | 책 이름 | 예 |
    | `[STITLE]` | 책 이름 약자 | 예 |
    | `[CHAP]` | 장 번호 | 예 |
    | `[PARA]` | 절 번호 | 아니요 |
    | `[BODY]` | 내용 | 아니요 |
    | `[BODY1]` ~ `[BODY9]` | 내용(다중 성경 지원) | 아니요 |

    | 실험용 치환자 | 내용 | *접미사* 지원 |
    | --- | --- | :---: |
    | `[CPAS]` | 시작 절 번호 | 아니요 |
    | `[CPAE]` | 끝 절 번호 | 아니요 |
* **접미사**: **치환자** 뒤에 오는 텍스트를 `:`로 구분하여 입력할 수 있습니다.
    **치환자**를 표시하지 않으면 **접미사**도 표시하지 않습니다.

    | 예시 | 내용 | 책 이름 생략 시 | 장 번호 생략 시 |
    | --- | --- | --- | --- |
    | `[TITLE: ][CHAP::[PARA]]` |  `창세기 1:1` |  `1:1` |  `창세기` |


## 기타 기능

* **오프라인 캐시**: **성경 구절**을 한번 내려받으면 인터넷 연결 없이 PPT를 만들 수 있습니다.
* **장별로 PPT 나누기**: `책 이름/장 번호.pptx`의 구조로 장별로 PPT를 만들어 저장합니다.


## 명령줄로 사용하기

`Bible2PPT.exe` 뒤에 **성경 구절**을 입력하면 화면 없이 PPT를 만듭니다.
다른 프로그램(예배 순서 자동화 스크립트 등)에서 호출할 때 사용하세요.

```
Bible2PPT.exe <성경 구절...> [옵션]
Bible2PPT.exe --list-bibles
```

| 옵션 | 설명 |
| --- | --- |
| `-o`, `--output <경로>` | PPT를 저장할 경로 (`--split`이면 폴더). 생략하면 임시 파일로 만들고 파워포인트로 엽니다. |
| `-b`, `--bible <성경>` | 사용할 성경의 ID 또는 이름. 여러 번 지정하면 나란히 배치합니다. 생략하면 프로그램에서 마지막으로 고른 성경을 사용합니다. |
| `-t`, `--template <경로>` | 사용할 템플릿 `.pptx`. 생략하면 프로그램 템플릿을 사용합니다. |
| `-l`, `--lines <0-9>` | 슬라이드당 성경 구절 줄 수 (`0`: 제한 없음). 생략하면 프로그램 설정을 따릅니다. |
| `-s`, `--split` | 장별로 PPT 나누기 (`--output` 필수) |
| `--open` | 완료 후 PPT 열기 (`--output`을 생략하면 항상 엶) |
| `--list-bibles` | 사용할 수 있는 성경의 ID와 이름 출력 |

* 성공하면 저장한 경로를 표준 출력으로 내보냅니다. 파이프로 받을 때는 UTF-8로 출력합니다.
* 종료 코드: `0` 성공, `1` 잘못된 인자, `2` PPT 만들기 실패, `3` 파워포인트 초기화 실패
* 성경 ID는 캐시를 지우면 바뀔 수 있으므로 자동화에는 성경 이름을 쓰는 것이 안전합니다.

```
Bible2PPT.exe 요3:16 롬8:28-39 -b 개역개정 -o C:\예배\본문.pptx
Bible2PPT.exe 시23 -b 개역개정 -b NIV --open
```


## 빌드 방법

**성경2PPT**는 PowerPoint COM 참조를 사용하기 때문에 `dotnet build`가 아닌 Visual Studio(Build Tools)의 MSBuild로 빌드해야 합니다.

### 빌드 요구 사항

* **Windows 10 / 11**
* **Visual Studio 2022 Build Tools** (*.NET 데스크톱 빌드 도구* 워크로드와 .NET SDK)
    ```powershell
    winget install --id Microsoft.VisualStudio.2022.BuildTools --exact --override "--wait --passive --norestart --add Microsoft.VisualStudio.Workload.ManagedDesktopBuildTools --add Microsoft.NetCore.Component.SDK --includeRecommended"
    ```
    Visual Studio 2022에서 *.NET 데스크톱 개발* 워크로드를 설치했다면 따로 설치하지 않아도 됩니다.
* **Microsoft PowerPoint**: 빌드할 때 PowerPoint의 COM 형식 라이브러리를 참조합니다.

### 빌드하기

저장소 폴더에서 [`build-release.ps1`](build-release.ps1)을 실행하세요.

```powershell
.\build-release.ps1 -Version 2.1.0                    # win-x86, win-x64 모두 빌드
.\build-release.ps1 -Version 2.1.0 -Runtimes win-x64  # win-x64만 빌드
.\build-release.ps1 -Version 2.1.0 -OutputDir D:\out  # 출력 폴더 지정
```

실행 정책 때문에 스크립트가 실행되지 않으면 `powershell -ExecutionPolicy Bypass -File .\build-release.ps1 -Version 2.1.0`으로 실행하세요.

빌드가 끝나면 `publish` 폴더에 다음 파일이 만들어집니다.

| 경로 | 내용 |
| --- | --- |
| `publish\win-x64\Bible2PPT.exe` | 64비트 실행 파일 |
| `publish\win-x86\Bible2PPT.exe` | 32비트 실행 파일 |
| `publish\Bible2PPT-<버전>-<런타임>.zip` | 배포용 압축 파일 |

실행 파일에는 .NET 런타임이 포함되어 있어 [실행 요구 사항](#실행-요구-사항)만 만족하면 설치 없이 바로 사용할 수 있습니다.


## 실행 요구 사항

### Windows 10 / 11
64비트 Windows에서는 `win-x64`, 32비트 Windows에서는 `win-x86` 버전을 사용하세요.
.NET 런타임은 실행 파일에 포함되어 있으므로 따로 설치하지 않아도 됩니다.

### Microsoft PowerPoint
PPT를 만들고 보는 데 필요한 프로그램입니다. Microsoft 365 또는 Office 2016 이상의 데스크톱용 PowerPoint를 권장합니다.
웹용 PowerPoint로는 사용할 수 없습니다.

### 인터넷 연결
**성경 구절**을 처음 받아올 때 인터넷 연결이 필요합니다.


## 기여 방법
**성경2PPT**는 당신의 기여를 기다리고 있습니다~ 사용 중 발생한 오류 혹은 추가하고 싶은 기능을 [Issues](https://github.com/sunghwan2789/Bible2PPT/issues) 페이지에 올려주세요!


## License
This software is licenced under the [MIT](LICENSE) © [Sunghwan Bang](https://github.com/sunghwan2789).
