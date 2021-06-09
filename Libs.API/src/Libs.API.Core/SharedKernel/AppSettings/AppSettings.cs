//using Halliburton.CPE.Models.CEC;
//using Halliburton.CPE.Models.Heimdall;
using System;
using System.Collections.Generic;

namespace Halliburton.App.Core.SharedKernel
{
    public class AppSettings
    {
        public Logging Logging { get; set; }

        public Management Management { get; set; }

        public ServiceInfo Info { get; set; }

        public Redis Redis { get; set; }

        public Mongodb Mongodb { get; set; }
        public MongodbConnection MongodbConnection { get; set; }

        public Spring Spring { get; set; }

        public Consul Consul { get; set; }

        public MSServiceInfo Msserviceinfo { get; set; }

        public string AllowedHosts { get; set; }

        public SandRampInputModelKeys SandRampInputModel { get; set; }

        public HeimdallKeys HeimdallKeys { get; set; }
        //public CECInputParameters CECInputParameters { get; set; }
        public HeimDallParameter HeimDallParameter { get; set; }
        public FluidTypesParameter FluidTypesParameter { get; set; }
        public DasCommanderConfigs DasCommanderConfigs { get; set; }
        public SyncServcieConfigs SyncServcieConfigs { get; set; }
    }

    public class SandRampParameter
    {
        public DefaultSlopeValue DefaultSlopeValue { get; set; }
    }
    public class DefaultSlopeValue
    {
        public double MinSlope { get; set; }
        public double MaxSlope { get; set; }
    }
    public class SyncServcieConfigs
    {
        public bool EnableTreatmentSync { get; set; }
    }

    public class DasCommanderConfigs
    {
        public bool AutoReplacePerf { get; set; }
    }

    public class HeimDallParameter
    {
        //public RequestData RequestData { get; set; }
    }

    public class FluidTypesParameter
    {
        public List<FluidTypes> FluidTypes { get; set; }
    }

    public class FluidTypes
    {
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
    }

    public class SandRampInputModelKeys
    {
        public string XfleetProject { get; set; }
        public string SandRampInput { get; set; }
        public string WellborePerformations { get; set; }
    }

    public class HeimdallKeys
    {
        public string TrackingStatus { get; set; }
    }

    public class Consul
    {
        public string Host { get; set; }

        public long Port { get; set; }

        public string Scheme { get; set; }

        public Discovery Discovery { get; set; }
    }

    public class Discovery
    {
        public bool PreferIpAddress { get; set; }

        public long Port { get; set; }

        public string Scheme { get; set; }

        public bool RegisterHealthCheck { get; set; }

        public string HealthCheckCriticalTimeout { get; set; }

        public Heartbeat Heartbeat { get; set; }
    }

    public class Heartbeat
    {
        public bool Enabled { get; set; }

        public long TtlValue { get; set; }

        public string TtlUnit { get; set; }
    }

    public class ServiceInfo
    {
        public string Service { get; set; }

        public string Version { get; set; }
    }

    public class Logging
    {
        public bool IncludeScopes { get; set; }

        public LogLevel LogLevel { get; set; }

        public ConsoleClass Console { get; set; }
    }

    public class ConsoleClass
    {
        public bool DisableColors { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }

        public string Pivotal { get; set; }

        public string Steeltoe { get; set; }
    }

    public class Management
    {
        public Endpoints Endpoints { get; set; }

        public Metrics Metrics { get; set; }
    }

    public class Endpoints
    {
        public string Path { get; set; }

        public Cloudfoundry Cloudfoundry { get; set; }
    }

    public class Cloudfoundry
    {
        public bool ValidateCertificates { get; set; }
    }

    public class Metrics
    {
        public Exporter Exporter { get; set; }
    }

    public class Exporter
    {
        public Cloudfoundry Cloudfoundry { get; set; }
    }

    public class Mongodb
    {
        public MongodbClient Client { get; set; }
    }

    public class MongodbConnection
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public class MongodbClient
    {
        public string Server { get; set; }

        public long Port { get; set; }

        public string Database { get; set; }
    }

    public class MSServiceInfo
    {
        public bool UsingApiUrl { get; set; }
        public string Userprofile { get; set; }

        public string Welldatamanager { get; set; }
        public string ProjectManager { get; set; }
        public string RealtimeService { get; set; }
        public string RealtimeServiceApiUri { get; set; }
        public string DataProcessingServiceApiUri { get; set; }
        public string DataProcessingService { get; set; }
        public string CECService { get; set; }
        public string CECServiceApiUri { get; set; }
        public string PressureServiceApiUri { get; set; }
        public string PressureService { get; set; }
    }

    public class Redis
    {
        public RedisClient Client { get; set; }
    }

    public class RedisClient
    {
        public string EndPoints { get; set; }
        public string ServiceName { get; set; }
        public long ConnectRetry { get; set; }
        public int KeepAlive { get; set; }
        public string TieBreaker { get; set; }

        public Channels Channels { get; set; }
        public string ConsumerGroupName { get; set; }
        public string ConsumerName { get; set; }
        public string WellMappingKeyPattern { get; set; }
        public string WellStageKey { get; set; }
        public string CurrentWellStageKey { get; set; }
        public Expires Expires { get; set; }
        public string LatestIFSJobKey { get; set; }
        public string RotationAngleKey { get; set; }
        public int RedLockTimeoutSecond { get; set; }
        public string CECStageKeyLock { get; set; }
    }

    public class Channels
    {
        public string MsInterServiceEvent { get; set; }
        public string ChannelMSInterServiceJobData { get; set; }
        public string ChannelMSInterServicePumpSchedule { get; set; }
        public string ChannelMSInterServiceOnDemand { get; set; }
        public string ChannelMSInterServiceDasCommanderIn { get; set; }
        public string ChannelMSInterServiceDasCommanderOut { get; set; }
        public string CHNXDataWells { get; set; }
        public string ChannelXFleetCmd { get; set; }
        public string ChannelMSInterServiceHeimdallResult { get; set; }
        public string ChannelMSInterServiceDasData { get; set; }
    }

    public class Spring
    {
        public Application Application { get; set; }
    }

    public class Application
    {
        public string Name { get; set; }
    }

    public class ExchangeTopic
    {
        public string ExchangeName { get; set; }
        public string Topic { get; set; }
    }
    public class Expires
    {
        public double KeyExpireTTL { get; set; }
    }
}
