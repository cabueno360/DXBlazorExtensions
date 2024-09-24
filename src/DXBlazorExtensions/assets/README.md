
# DXBlazorExtensions

DXBlazorExtensions is a powerful library built upon DevExpress Blazor, offering custom components to enhance web applications. Designed for flexibility and performance, it expands the DevExpress ecosystem, providing developers with innovative tools to create rich, responsive Blazor applications with ease.

## Features

- Custom components extending the DevExpress Blazor suite
- Flexible and responsive design for web applications
- Seamless integration with DevExpress Blazor controls
- Easy to use and configure

## Installation

You can install the **DXBlazorExtensions** NuGet package via the NuGet Package Manager, or using the .NET CLI.

### NuGet Package Manager

1. Open your project in Visual Studio.
2. Right-click on the project and select `Manage NuGet Packages`.
3. Search for `DXBlazorExtensions` and install it.

### .NET CLI

```bash
dotnet add package DXBlazorExtensions
```

## Usage

After installing the package, you can start using the custom components by following the steps below.

### 1. Add the required imports

In your `_Imports.razor` file, make sure to include the following:

```razor
@using DXBlazorExtensions
@using DevExpress.Blazor
```

### 2. Use a Component

Here is an example of how to use one of the custom components, such as the `DxCard` component.

#### Example: Using `DxCard`

```razor
<DxCard Title="Sample Card" Subtitle="Card Subtitle">
    <DxCardContent>
        <p>This is a custom card component created with DXBlazorExtensions.</p>
    </DxCardContent>
</DxCard>
```

#### Example: Using `DxListView`

```razor
<DxListView Items="@listItems" ItemTemplate="listTemplate">
    <ItemTemplateContext>
        <div>
            <p>@context.Item</p>
        </div>
    </ItemTemplateContext>
</DxListView>

@code {
    List<string> listItems = new List<string> { "Item 1", "Item 2", "Item 3" };

    RenderFragment<string> listTemplate = item => @<div>@item</div>;
}
```

### 3. Configuring Responsive Pages

You can also utilize the `ResponsivePage` component to build adaptable layouts that respond to different screen sizes.

#### Example: Using `ResponsivePage`

```razor
<ResponsivePage>
    <h3>Responsive Design Example</h3>
    <p>This page adjusts layout based on screen size.</p>
</ResponsivePage>
```

## Contributing

We welcome contributions to improve the library. Please feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
