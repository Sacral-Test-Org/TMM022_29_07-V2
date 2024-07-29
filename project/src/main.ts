import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';

// Main entry point of the Angular application
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));