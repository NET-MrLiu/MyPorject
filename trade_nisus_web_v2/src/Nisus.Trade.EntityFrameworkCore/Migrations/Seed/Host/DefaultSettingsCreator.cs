using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using Microsoft.EntityFrameworkCore;
using Nisus.Trade.EntityFrameworkCore;

namespace Nisus.Trade.Migrations.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly TradeDbContext _context;

        public DefaultSettingsCreator(TradeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //Emailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "1263586498@qq.com");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "mydomain.com mailer");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Port,"587");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Host,"smtp.qq.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UserName,"1263586498@qq.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Password, "bwhnkfjqimpmjfif");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Domain,"");
            AddSettingIfNotExists(EmailSettingNames.Smtp.EnableSsl,"true");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UseDefaultCredentials,"false");
            //Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "en");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}