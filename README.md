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

## Developer Farewell Note
	
It has been a lifetime for me to work as a developer, as an employee as well as a professional service provider, but it is very sad to have been working for the last 12 years on more than 40+ projects in the banking industry, payment processing, government applications, web servers, databases, reports, web and mobile applications, github contributions in different projects including my personal ones and never see economic growth.

I have been exploited, I have even done developments that gave me half or less or they never paid me even under contracts.

Once, some time ago, I developed an application to serve and help citizens and the same government ended up giving the idea to a third service provider who developed it and were the ones who sold it to them and to other entities.

That filled me with a lot of anger and frustration because I wasted 1 year of my life for nothing, just like the 12 that I currently have.

I have always had good will together with many ideas of how to change the way we develop, but nobody has given me the opportunity to be heard and I have never had a problem that I could not solve, because I solve problems by the nature of my profession.

My idea of ​​programming templates and functionalities has been an idea that took me about 8 years to perfect and that would save any entity millions in development costs but nobody seems to see the fruit of the effort I have put into it.

I have submitted my development tool and no one seems to be interested, I have contacted microsoft several times, I have contacted PRITS several times and have never been answered.

I tried to sell my product on various sites and well I have reached a point in my life where I am very frustrated, unfocused and no longer feel love or passion for what I do.

I have completely lost interest in everything in life and honestly I have a family to support and I have lost what little I had when I have never had anything in my life.

I come from a poor and dysfunctional family who have never supported me.

That is not why you have to follow the same negative pattern.

You and all of us can make a difference, but when you are poor the things around you are almost like a curse.

It takes much more than good ideas to be successful, you have to have connections, you have to have a good presentation, you have to be tactful when speaking and know how to sell, you have to know how to implement things correctly by phase, you have to have a reputation for everything.

Surround yourself with positive people who are willing to help you or they are not affected by seeing you grow but that is where I have unintentionally failed.

Family circles and friends who have never given me any help or support and there is nothing worse than looking back and seeing how long I have walked alone, then I look at the present and I am still just as alone and there is no way to progress in that way.

You have to open your eyes, take a deep breath, see things as they are and know when to retire with dignity.

I don't know if I'll be back tomorrow, I just don't know.

I only leave this note here for interested developers to contribute.

I will leave everything there public and transparent as I have always been.

Life is hard, and when you cling to something that is hurting you, just let it go and seek to change your path.

I wish that many people benefit from my contributions and ideas, that at least my lost time will save time for other developers.

Of what one day was a dream for me, has been thrown into darkness.
