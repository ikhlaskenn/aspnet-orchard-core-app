using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.ContentManagement.Metadata.Builders;
using OrchardCore.Data.Migration;

namespace ProjectModule.Migrations;

public class Migrations : DataMigration
{
    private readonly IContentDefinitionManager _content;
    public Migrations(IContentDefinitionManager content) => _content = content;

    public int Create()
    {
        // Fully-qualified calls to the extension methods:
        OrchardCore.ContentManagement.Metadata.ContentDefinitionManagerExtensions
          .AlterPartDefinitionAsync(_content, "ProjectPart", part => part
                .WithField("Description", f => f.OfType("TextField").WithDisplayName("Description"))
                .WithField("Image", f => f.OfType("MediaField").WithDisplayName("Image"))
                .WithField("ProjectLink", f => f.OfType("LinkField").WithDisplayName("Project Link"))
            );

        OrchardCore.ContentManagement.Metadata.ContentDefinitionManagerExtensions
           .AlterTypeDefinitionAsync(_content, "Project", type => type
                .WithPart("TitlePart")
                .WithPart("ProjectPart")
                .Creatable()
                .Listable()
            );

        return 1;
    }
}
