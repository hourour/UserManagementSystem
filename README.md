# UserManagementSystem

這是一個使用 ASP.NET Core MVC + SQLite/MySQL 開發的簡易管理系統，提供使用者登入、帳號管理、與個人任務工作進度管理功能。

## 🔧 技術棧

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite / MySQL（可切換）
- Bootstrap（前端樣式）
- Session 驗證（簡易登入系統）

## 📌 功能介紹

- 使用者新增、編輯、刪除、瀏覽
- 登入驗證（依帳號密碼登入）
- 每位使用者可查看、編輯自己任務進度
- 任務欄位：
  - 任務名稱
  - 緊急程度（緊急 / 一般 / 不急）
  - 截止日期
  - 進度階段（開始、進行中、主管審核、上線測試、完成）

## 📂 資料表設計（簡化）

### Users
| 欄位名稱 | 說明       |
|----------|------------|
| Id       | 使用者編號 |
| Name     | 姓名       |
| Email    | 信箱       |
| Account  | 帳號       |
| Password | 密碼       |

### WorkProgress
| 欄位名稱      | 說明                         |
|---------------|------------------------------|
| Id            | 任務編號                     |
| UserId        | 對應使用者 Id（外鍵）        |
| TaskName      | 任務名稱                     |
| Urgency       | 緊急程度（緊急/一般/不急）   |
| Deadline      | 截止日（可為 NULL）          |
| ProgressStage | 進度階段                     |

## 🧭 導覽

- `/Users` 使用者管理
- `/Login` 登入頁面
- `/WorkProgress` 登入後查看自己任務清單



