# Add remote cho repo local
git remote add <name> <url>
git remote add giengdawebapp https://github.com/thanh211211/giengdawebapp.git
sau đó commit và push code lên remote

#cách Combine nhiều commit đã commit lên remote
>git rebase -i HEAD~3	=> 3 là số các commit muốn Combine 
sau lệnh này hiện cửa sổ edit, thay thế pick bằng squash(hoặc s) từ line thứ 2. Line đầu tiên giữ nguyên pick hoặc pick
=> bấm Esc rồi bấm :wq để lưu và thoát chế độ edit
>git push --force origin HEAD
=> thêm --force để ghi đè lại code đã commit. Nó ghi đề luôn các commit của dev khác
git push --force-with-lease origin HEAD
=> --force-with-lease an toàn hơn, sẽ không ghi đè commit của dev khác.