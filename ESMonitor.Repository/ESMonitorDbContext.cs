using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EsMonitor.Model;

namespace ESMonitor.Repository
{
    /// <summary>
    /// 数据仓库基础环境类
    /// </summary>
    public class EsMonitorDbContext : DbContext
    {
        /// <summary>
        /// 创建默认的DbContext
        /// </summary>
        public EsMonitorDbContext() : base("SHWDTech_ESMonitor")
        {
            
        }

        /// <summary>
        /// 创建默认的DbContext
        /// </summary>
        /// <param name="connString">连接字符串或连接字符串名称</param>
        public EsMonitorDbContext(string connString) : base(connString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<EsUser>()
                .HasMany(s => s.Roles)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserId");
                    cs.MapRightKey("RoleId");
                    cs.ToTable("UserRole");
                });

            modelBuilder.Entity<Permission>()
                .HasMany(s => s.Roles)
                .WithMany(c => c.Permissions)
                .Map(cs =>
                {
                    cs.MapLeftKey("PermissionId");
                    cs.MapRightKey("RoleId");
                    cs.ToTable("RolePermission");
                });

            modelBuilder.Entity<Permission>()
                .HasMany(s => s.Users)
                .WithMany(c => c.Permissions)
                .Map(cs =>
                {
                    cs.MapLeftKey("PermissionId");
                    cs.MapRightKey("UserId");
                    cs.ToTable("UserPermission");
                });

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 报警信息
        /// </summary>
        public virtual DbSet<Alarm> Alarms { get; set; }

        /// <summary>
        /// 摄像头
        /// </summary>
        public virtual DbSet<Camera> Cameras { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public virtual DbSet<Device> Devices { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        public virtual DbSet<Module> Modules { get; set; }

        /// <summary>
        /// 监测数据
        /// </summary>
        public virtual DbSet<MonitorEsData> MonitorDatas { get; set; }

        /// <summary>
        /// 系统权限
        /// </summary>
        public virtual DbSet<Permission> Permissions { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public virtual DbSet<Photo> Photos { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        public virtual DbSet<Project> Projects { get; set; }

        /// <summary>
        /// 固件
        /// </summary>
        public virtual DbSet<Firmware> Firmwares { get; set; }

        /// <summary>
        /// 固件集
        /// </summary>
        public virtual DbSet<FirmwareSet> FirmwareSets { get; set; }

        /// <summary>
        /// 协议信息
        /// </summary>
        public virtual DbSet<Protocol> Protocols { get; set; }

        /// <summary>
        /// 协议数据包
        /// </summary>
        public virtual DbSet<ProtocolData> ProtocolDatas { get; set; }

        /// <summary>
        /// 系统角色
        /// </summary>
        public virtual DbSet<EsRole> Roles { get; set; }

        /// <summary>
        /// 系统配置
        /// </summary>
        public virtual DbSet<EsSystemConfig> SysConfigs { get; set; }

        /// <summary>
        /// 系统域
        /// </summary>
        public virtual DbSet<Domain> SysDomains { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public virtual DbSet<EsUser> Users { get; set; }

        /// <summary>
        /// 用户配置
        /// </summary>
        public virtual DbSet<UserConfig> UserConfigs { get; set; }

        /// <summary>
        /// 系统自定义词典
        /// </summary>
        public virtual DbSet<EsSystemDictionary> SysDictionaries { get; set; }

        /// <summary>
        /// 用户自定义词典
        /// </summary>
        public virtual DbSet<UserDictionary> UserDictionaries { get; set; }

        /// <summary>
        /// 协议结构
        /// </summary>
        public virtual DbSet<ProtocolStructure> ProtocolStructures { get; set; }

        /// <summary>
        /// 协议指令
        /// </summary>
        public virtual DbSet<ProtocolCommand> ProtocolCommands { get; set; }

        /// <summary>
        /// 指令数据
        /// </summary>
        public virtual DbSet<CommandData> CommandDatas { get; set; }

        /// <summary>
        /// 指令定义数据
        /// </summary>
        public virtual DbSet<CommandDefinition> CommandDefinitions { get; set; }

        /// <summary>
        /// 公司部门
        /// </summary>
        public virtual DbSet<Department> Departments { get; set; }
    }
}
