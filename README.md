# Simple Hacker News reader using Blazor WASM [(Demo)](https://erwinkn.github.io/hnpwa-blazor)
Yet another Hacker News reader, implemented as a Blazor progressive web application, in the spirit of the [HNPWA](https://hnpwa.com/) benchmark.

The goal was to see how Blazor WASM performs compared to the popular Javascript SPA frameworks and try to optimize its performance as much as possible. **Spoiler:** much lower Lighthouse scores due to the initial download of the 4MB .NET runtime, but once you're past that, rendering speeds are very good, handling threads with hundreds of nested components without a problem.

If you have any suggestion on how to further improve this demo, **please open an issue!**

## Under the hood:
- [Tailwind CSS](https://tailwindcss.com/) integration
- Easy NPM + PostCSS + .NET build process
- Code-behind components
- Progressive web application (PWA) capabilities
- Uses the [unofficial HN API](https://github.com/cheeaun/node-hnapi), since it is much better suited for external development

## What I'm looking into:
- Virtualization for long comment threads
- Server-side prerendering, ideally having the server do the first API call, render the page and send it to the client while the .NET runtime is downloading.
