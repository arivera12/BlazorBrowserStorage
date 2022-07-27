# BlazorBrowserStorage

<p>
    	<a href="https://www.nuget.org/packages/BlazorBrowserStorage">
	    <img src="https://buildstats.info/nuget/BlazorBrowserStorage?v=1.0.0" />
	</a>
</p>

HTML5 Storage API for Blazor without any JavaScript Library Dependency.

This package wraps [HTML5 Storage](https://developer.mozilla.org/en-US/docs/Web/API/Storage) APIs. 

Both Session and Local storage types are supported.

## Installation

`Install-Package BlazorBrowserStorage -Version 1.0.0`

## Register the service in your services method

`services.AddBlazorBrowserStorage();`

## No javascript library reference dependency

This library was ported and improved from [BlazorExtensions.Storage](https://github.com/BlazorExtensions/Storage) but removing any javascript dependency.

## Usage

`[Inject] ISessionStorage SessionStorage { get; set; }` for session storage

`[Inject] ILocalStorage LocalStorage { get; set; }` for local storage

### BlazorBrowserStorage ISessionStorage/ILocalStorage Methods

<table>
	<tr>
		<th>BlazorBrowserStorage ISessionStorage/ILocalStorage</th>
		<th>Method</th>
	</tr>
	<tr>
		<td>Gets the Length of items in storage</td>
		<td>Length()</td>
	</tr>
	<tr>
		<td>Clears all items in storage</td>
		<td>Clear()</td>
	</tr>
	<tr>
		<td>Gets an item by key of a type from the storage</td>
		<td>GetItem&lt;T&gt;(string key)</td>
	</tr>
  <tr>
		<td>Gets a key name by index from the storage</td>
		<td>Key()</td>
	</tr>
  <tr>
		<td>Remove an item by key from the storage</td>
		<td>RemoveItem(string key)</td>
	</tr>
  <tr>
		<td>Sets an item by key and by item type in the storage</td>
		<td>SetItem&lt;T&gt;(string key, T item)</td>
	</tr>
</table>

## License
MIT
