# 🌿 Arduino & Unity Smart Farm Monitoring System

Arduino 기반의 하드웨어 센서 데이터와 PC 환경의 **Unity UI(UI Toolkit)**를 실시간으로 연동하여 온실 환경을 모니터링하고 제어하는 스마트팜 프로젝트입니다.

---

## 🚀 Key Features (주요 기능)
- **Real-time Sensor Monitoring:** 온도, 습도, 조도 데이터를 실시간으로 측정 및 시각화
- **Dual Display System:** 
  - 하드웨어 독립 구동: I2C LCD(16x2)를 통한 현장 데이터 출력
  - PC 시각화: 유니티(Unity) UI Toolkit 기반의 프로그레스바 및 대시보드 표시
- **Serial Communication:** Serial 통신(9600 Baud Rate)을 활용한 안정적인 데이터 패킷 전송 (`T,H,L`)
- **Modular Architecture:** C# 싱글톤 패턴과 예외 처리를 통한 견고한 통신 및 UI 바인딩

---

## 🛠️ Tech Stack & Environment (개발 환경)
- **Hardware:**
  - Arduino Uno
  - DHT11 (Temperature & Humidity Sensor)
  - CDS (Light / Illuminance Sensor)
  - Relay Module (Water Pump Control)
  - Buzzer / I2C LCD (16x2)
- **Software:**
  - Arduino IDE
  - Unity (UI Toolkit, C#)

---

## 📂 Project Structure (프로젝트 구조)
```text
Smart_Farm/
│
├── Assets/
│   ├── Scripts/
│   │   ├── Connect_Arduino.cs  # 시리얼 통신 및 데이터 파싱 담당
│   │   └── main.cs             # 유니티 UI 바인딩 및 프로그레스바 연동
│   └── UI/                     # UI Toolkit (UXML, USS)
│
├── Arduino/
│   └── SmartFarm_Firmware.ino  # 아두이노 센서 제어 및 시리얼 송신 코드
│
└── README.md
```

## Result
https://github.com/user-attachments/assets/856181c1-4ec4-4762-85f7-33d0cb3a9e1a


