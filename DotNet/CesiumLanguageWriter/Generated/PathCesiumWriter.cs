// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Path</c> to a <see cref="CesiumOutputStream" />.  A <c>Path</c> is a path, which is a polyline defined by the motion of an object over time. The possible vertices of the path are specified by the <c>position</c> property. Note that because clients cannot render a truly infinite path, the path must be limited, either by defining availability for this object, or by using the <c>leadTime</c> and <c>trailTime</c> properties.
    /// </summary>
    public class PathCesiumWriter : CesiumPropertyWriter<PathCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>width</c> property.
        /// </summary>
        public const string WidthPropertyName = "width";

        /// <summary>
        /// The name of the <c>resolution</c> property.
        /// </summary>
        public const string ResolutionPropertyName = "resolution";

        /// <summary>
        /// The name of the <c>leadTime</c> property.
        /// </summary>
        public const string LeadTimePropertyName = "leadTime";

        /// <summary>
        /// The name of the <c>trailTime</c> property.
        /// </summary>
        public const string TrailTimePropertyName = "trailTime";

        /// <summary>
        /// The name of the <c>material</c> property.
        /// </summary>
        public const string MaterialPropertyName = "material";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_width = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(WidthPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_resolution = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(ResolutionPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_leadTime = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(LeadTimePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_trailTime = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(TrailTimePropertyName), false);
        private readonly Lazy<PolylineMaterialCesiumWriter> m_material = new Lazy<PolylineMaterialCesiumWriter>(() => new PolylineMaterialCesiumWriter(MaterialPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public PathCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected PathCesiumWriter(PathCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override PathCesiumWriter Clone()
        {
            return new PathCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the path is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>width</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>width</c> property defines the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter WidthWriter
        {
            get { return m_width.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>width</c> property.  The <c>width</c> property defines the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OpenWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(WidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteWidthProperty(double value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteWidthPropertyReference(Reference value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteWidthPropertyReference(string value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the path line.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>resolution</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>resolution</c> property defines the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        public DoubleCesiumWriter ResolutionWriter
        {
            get { return m_resolution.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>resolution</c> property.  The <c>resolution</c> property defines the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        public DoubleCesiumWriter OpenResolutionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ResolutionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>number</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteResolutionProperty(double value)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>number</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteResolutionProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>number</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteResolutionProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>reference</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteResolutionPropertyReference(Reference value)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>reference</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteResolutionPropertyReference(string value)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>reference</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteResolutionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>resolution</c> property as a <c>reference</c> value.  The <c>resolution</c> property specifies the maximum step-size, in seconds, used to sample the path. If the <c>position</c> property has data points farther apart than resolution specifies, additional samples will be computed, creating a smoother path.  If not specified, the default value is 60.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteResolutionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenResolutionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>leadTime</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>leadTime</c> property defines the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        public DoubleCesiumWriter LeadTimeWriter
        {
            get { return m_leadTime.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>leadTime</c> property.  The <c>leadTime</c> property defines the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        public DoubleCesiumWriter OpenLeadTimeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LeadTimeWriter);
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>number</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLeadTimeProperty(double value)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>number</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteLeadTimeProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>number</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteLeadTimeProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>reference</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteLeadTimePropertyReference(Reference value)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>reference</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteLeadTimePropertyReference(string value)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>reference</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteLeadTimePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>leadTime</c> property as a <c>reference</c> value.  The <c>leadTime</c> property specifies the time ahead of the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteLeadTimePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenLeadTimeProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>trailTime</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>trailTime</c> property defines the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        public DoubleCesiumWriter TrailTimeWriter
        {
            get { return m_trailTime.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>trailTime</c> property.  The <c>trailTime</c> property defines the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        public DoubleCesiumWriter OpenTrailTimeProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(TrailTimeWriter);
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>number</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteTrailTimeProperty(double value)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>number</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteTrailTimeProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>number</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteTrailTimeProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>reference</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTrailTimePropertyReference(Reference value)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>reference</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteTrailTimePropertyReference(string value)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>reference</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteTrailTimePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>trailTime</c> property as a <c>reference</c> value.  The <c>trailTime</c> property specifies the time behind the animation time, in seconds, to show the path. The time will be limited to not exceed the object's availability. By default, the value is unlimited, which effectively results in drawing the entire available path of the object.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteTrailTimePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenTrailTimeProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>material</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>material</c> property defines the material to use to draw the path.
        /// </summary>
        public PolylineMaterialCesiumWriter MaterialWriter
        {
            get { return m_material.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>material</c> property.  The <c>material</c> property defines the material to use to draw the path.
        /// </summary>
        public PolylineMaterialCesiumWriter OpenMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaterialWriter);
        }

    }
}
