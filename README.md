# Khóa học Làm dự án với ASP.NET Core MVC Tedu

## 1. Tổng quan

Course content

- Build a completed application from scratch
- Database design
- Admin page for management
- Frontend page for customer
- Entity framework code first
- Git source control

Technologies

- ASP.NET Core 3.1
- Entity Framework Core 3.1
- SQL Server 2019
- C# 8.0

Required skills

- HTML & CSS
- Javascript basic
- C# basic
- SQL Server basic

## 2. Tạo dự án

Tạo `solution` mới

- Mở visual studio
- Tạo dự án mới
- Tìm kiếm từ khóa `blank`
- Tạo `blank solution`, đặt tên `eShopSolution`

![Image](md_assets/eshopsolution.png)

Tạo `project` mới

- Chuột phải lên `solution`
- Chọn `new project`
- Tìm kiếm `ASP.NET Core Web Application (MVC)`
- Đặt tên `project` là `eShopSolution.WebApp`

![Image](md_assets/eshopsolution.webapp.png)

Cấu trúc thư mục `project`

- Mô hình `MVC`
- `appsettings.json`: chứa các cài đặt cho ứng dụng, có thể tạo nhiều `appsetting` cho các môi trường khác nhau như: `dev`, `prod`, `staging`, ...
- `wwwroot`: chứa các thành phần tĩnh: `css`, `js` hay `image`
- `Program.cs`: `entry point` của ứng dụng
- `Startup.cs`: Chứa các cài đặt, cấu hình, `middleware`,...
- Trong `properties`, `launchSettings.json` chứa các cấu hình chạy server, được định nghĩa tại khóa `profiles`: bao gồm `IIS Express` và tự `host`. Thường sẽ 
chọn tự host

![Image](md_assets/launchsettings.png)
