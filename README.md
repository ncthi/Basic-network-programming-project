# Basic network programming project (2023)
### Nguyên lý hoạt động
1. Khi đăng ký trên client: Nhận thông tin tài khoản, sau đó gửi tên user và password tới server để tạo tài khoản nếu tạo thành công server trả về true, không thành công thì trả về false.
2. Khi server nhận được thông tin đăng ký từ client: Kiểm tên user đã tồn tại hay chưa nếu chưa tồn tại thì tạo user mới trên FTP server và ghi vào database, trả về true nếu tạo thành công
3. Khi đăng nhập trên client: Client sẽ kết nối với FTP server với tài khoản đã tạo trước đó.
4. Quản lý trên server: Server có thể quản lý thông tin tài khoản vầ khôi phục mật khẩu.
5. Ở client và server đều có file manager để hiện thư mục trên FTP server để có thể xem, upload, download file.
### Những nguyên tắc khi sử dụng github
1. Chỉ làm việc trên nhánh của mình.
2. Trước khi code nên pull về để cập nhật code mới.
3. Commit rõ ràng.
3. Hoàn thành 1 cái gì đó thì tạo pull request (**Lưu ý chỉ tạo pull request không confirm**).
4. Thay đổi một cái gì đó quan trọng nên tạo bản backup.
### Những nguyên tắc khi code.
1. Tên biến đặt theo nguyên tắc con lạc đà. Ví dụ: phoneNumber, countLine,......
2. Tên class và hàm viết hoa các chữ cái đầu. Ví dụ MyFile, FormMain,.....
3. Tên toolbox cần có tiền tố. Ví dụ: textBox_Name, button_Read,...
4. Nên comment những chỗ khó hiểu.
5. Những đoạn code nào không sử dụng nữa nên xóa đi.
6. Những phần có nhiều công việc liên quan cần viết 1 class.
### Phân chia công việc
1. Viết class kết nối với SQL server (Thi)
2. Làm giao diện quản lý file. Link tham khảo: :
3. [Link1](https://www.youtube.com/watch?v=oRtME1oJD7M), [link1](https://www.youtube.com/watch?v=LT97kQWf7wU&list=PL-EU0JUF-XD1saII7gONUxMIbk13XkmCV&index=99) (Lê)
4. Viết class thực hiện các thao tác với FTP server. Link Tham khảo: [link](https://megacode.vn/files/view/ket-noi-ftp-server-bang-c-1901.html#:~:text=K%E1%BA%BFt%20n%E1%BB%91i%20FTP%20server%20b%E1%BA%B1ng%20C%23%202013-09-03T09%3A00-03%3A00%20%C4%90%C4%83ng,function%20of%20choice%2C%20v%C3%A0%20free%20resource.%200.73684210526316%2F10%208711) (Ngân)
5. Thiết kế form đăng nhập. (Thái) (Đã xong)
6. Viết socket gửi tên user và password tới server (Thái) (Đã xong)
7. Viết socket nhận tên user và password (Thi)
8. Viết 1 class gửi mail body là html với nội dụng là 1 mật khẩu random khi quên mật khẩu (viết bên server). Link tham khảo: [link1](https://stackoverflow.com/questions/1155797/send-an-email-with-a-html-file-as-body-c), [link2](https://www.phanxuanchanh.com/2021/09/16/lap-trinh-c-gui-email-don-gian-bang-giao-thuc-smtp/) (Thái)
9. Thêm chức năng cho file manager (upload, download, rename, copy, cut, new file, new folder). (Ngân, Lê)
10. Viết hàm thêm user và xóa user trên server (Thi)
