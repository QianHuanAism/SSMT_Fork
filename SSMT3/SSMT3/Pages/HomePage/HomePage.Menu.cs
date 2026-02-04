using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMT3
{
    public partial class HomePage
    {

        private void MenuFlyoutItem_GameIcon_TurnOnSymlink_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string analyse_options = PathManager.analyse_options + " symlink";
                D3dxIniConfig.SaveAttributeToD3DXIni(PathManager.Path_D3DXINI, "[hunting]", "analyse_options", analyse_options);
                _ = SSMTMessageHelper.Show("已开启Symlink特性，游戏内F10刷新生效");
            }
            catch(Exception ex)
            {
                _ = SSMTMessageHelper.Show(ex.ToString());
            }

        }

        private void MenuFlyoutItem_GameIcon_TurnOffSymlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string analyse_options = PathManager.analyse_options;
                D3dxIniConfig.SaveAttributeToD3DXIni(PathManager.Path_D3DXINI, "[hunting]", "analyse_options", analyse_options);
                _ = SSMTMessageHelper.Show("已关闭Symlink特性，游戏内F10刷新生效");
            }
            catch (Exception ex)
            {
                _ = SSMTMessageHelper.Show(ex.ToString());
            }
        }

    }
}
