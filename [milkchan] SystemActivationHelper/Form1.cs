using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _milkchan__SystemActivationHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 관리자 권한 체크
            if (!IsAdministrator())
            {
                MessageBox.Show("⚠️ 이 프로그램은 관리자 권한으로 실행되어야 합니다.\n\n관리자 권한으로 다시 실행해주세요.", "관리자 권한 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); // 프로그램 종료
            }
        }

        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void home_Click(object sender, EventArgs e)
        {
            try
            {
                // 경고 메시지 (0xC004F069 관련)
                MessageBox.Show("⚠️ 이 인증 방식은 일부 윈도우 버전에서 오류(0xC004F069)가 발생할 수 있습니다.\n\n예: 제품 키가 맞지 않거나 정품 설치가 되어 있지 않은 경우\n\n계속하시겠습니까?", "정품인증 주의", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 실행 전 메시지
                MessageBox.Show("정품인증을 시작합니다. (예상 대기시간: 30초)");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c \"slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 && timeout /t 5 /nobreak >nul && slmgr /skms kms8.msguides.com && timeout /t 5 /nobreak >nul && slmgr /ato\"";

                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas"; // 관리자 권한 실행

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show("정품인증이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void pro_Click(object sender, EventArgs e)
        {
            try
            {
                // 경고 메시지 (0xC004F069 관련)
                MessageBox.Show("⚠️ 이 인증 방식은 일부 윈도우 버전에서 오류(0xC004F069)가 발생할 수 있습니다.\n\n예: 제품 키가 맞지 않거나 정품 설치가 되어 있지 않은 경우\n\n계속하시겠습니까?", "정품인증 주의", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 실행 전 메시지
                MessageBox.Show("정품인증을 시작합니다. (예상 대기시간: 30초)");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c \"slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX && timeout /t 5 /nobreak >nul && slmgr /skms kms8.msguides.com && timeout /t 5 /nobreak >nul && slmgr /ato\"";

                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas"; // 관리자 권한 실행

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show("정품인증이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void education_Click(object sender, EventArgs e)
        {
            try
            {
                // 경고 메시지 (0xC004F069 관련)
                MessageBox.Show("⚠️ 이 인증 방식은 일부 윈도우 버전에서 오류(0xC004F069)가 발생할 수 있습니다.\n\n예: 제품 키가 맞지 않거나 정품 설치가 되어 있지 않은 경우\n\n계속하시겠습니까?", "정품인증 주의", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 실행 전 메시지
                MessageBox.Show("정품인증을 시작합니다. (예상 대기시간: 30초)");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c \"slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 && timeout /t 5 /nobreak >nul && slmgr /skms kms8.msguides.com && timeout /t 5 /nobreak >nul && slmgr /ato\"";

                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas"; // 관리자 권한 실행

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show("정품인증이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void enterprise_Click(object sender, EventArgs e)
        {
            try
            {
                // 경고 메시지 (0xC004F069 관련)
                MessageBox.Show("⚠️ 이 인증 방식은 일부 윈도우 버전에서 오류(0xC004F069)가 발생할 수 있습니다.\n\n예: 제품 키가 맞지 않거나 정품 설치가 되어 있지 않은 경우\n\n계속하시겠습니까?", "정품인증 주의", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 실행 전 메시지
                MessageBox.Show("정품인증을 시작합니다. (예상 대기시간: 30초)");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c \"slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43 && timeout /t 5 /nobreak >nul && slmgr /skms kms8.msguides.com && timeout /t 5 /nobreak >nul && slmgr /ato\"";

                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas"; // 관리자 권한 실행

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show("정품인증이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
    }
}
