namespace MassEffect.Engine
{
    using Commands;

    public class CommandManagerExtended : CommandManager
    {
        public override void SeedCommands()
        {
            base.SeedCommands();

            this.commandsByName["system-report"] = new SystemReportCommand(this.Engine);
        }
    }
}