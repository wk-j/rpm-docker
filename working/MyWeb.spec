Name: my-web
Version: 1
Release: 1
Summary: My Web
License: FIXME

%description
This is my first RPM package

%prep
# We have no source

%install
mkdir -p %{buildroot}/usr/share/my-web
cp -a /working/publish/. %{buildroot}/usr/share/my-web

%files
/usr/share/my-web
